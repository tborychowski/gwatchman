using System;
using System.Xml;
using System.Net;
using System.Text;

public class Google
{

    #region Vars 

    private int gmailTempCount = -1;
    private int gmailCount = 0;

    private int readerTempCount = -1;
    private int readerCount = 0;

	private bool gmailForcePopup, readerForcePopup;

    private string SID = "";
    private string Token = "";
    private string Auth = "";

	public delegate void CheckHandler(string status, string message);
	public event CheckHandler MailComplete;
	public event CheckHandler ReaderComplete;
	public event CheckHandler showPopup;

	public Boolean debug = false;
	public Boolean useProxy = false;
	private string errorLog = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\GWatch.log";

	#endregion Vars


	#region Gmail

	public void gmailCheck(string usn, string pas, bool forcePopup = false){
		if (usn == "" || pas == "") {
			if (this.debug) this.log("Gmail error: username or password missing");
			MailComplete("error", "Username or password missing");
			return; 
		}

		String gUrl = "https://mail.google.com/mail/feed/atom/unread"; // show all folders
		this.gmailForcePopup = forcePopup;
        WebClient gmailClient = new WebClient();
		if (useProxy) {
			gmailClient.Proxy = WebRequest.GetSystemWebProxy();
			gmailClient.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
		}
        gmailClient.Credentials = new NetworkCredential(usn, pas);
        gmailClient.DownloadDataCompleted += new DownloadDataCompletedEventHandler(this.gmailComplete);
        gmailClient.DownloadDataAsync(new Uri(gUrl));
    }

    private void gmailComplete(Object sender, DownloadDataCompletedEventArgs e){
		if (this.debug) this.log("Gmail check complete.");
		Exception error = e.Error;
		if (error != null) {
			if (this.debug) {
				MailComplete("error", error.Message);
				this.log("Error: " + error.Message);
			}
			else MailComplete("error", "Cannot log in");		// human readable error - for tray icon tooltip
		}
		else {
			XmlNode node;
			XmlDocument xmlDoc = new XmlDocument();
			byte[] result = e.Result;
			String response = Encoding.UTF8.GetString(result);

			xmlDoc.LoadXml(response);
			XmlNamespaceManager xmlnsManager = new XmlNamespaceManager(xmlDoc.NameTable);
			xmlnsManager.AddNamespace("ns", "http://purl.org/atom/ns#");
			node = xmlDoc.SelectSingleNode("/ns:feed/ns:fullcount", xmlnsManager);
			this.gmailTempCount = int.Parse(node.InnerText);

			String retVal = "";
			if (this.gmailTempCount == 0) retVal = "0";
			else retVal = this.gmailTempCount.ToString();

			if (((this.gmailCount != this.gmailTempCount) && this.gmailTempCount > 0) || this.gmailForcePopup == true) showPopup("mail", retVal);
			MailComplete("success", retVal);
			if (this.debug) this.log("Gmail success: parse complete. Count: " + retVal);

			this.gmailCount = this.gmailTempCount;
		}
    }

    #endregion Gmail

    #region Google Reader

	public void readerCheck(string usn, string pas, bool refreshAuth = false, bool forcePopup = false){
		if (usn == "" || pas == "") {
			if (this.debug) this.log("Reader error: Username or password missing");
			ReaderComplete("error", "Username or password missing");
			return;
		}
		this.readerForcePopup = forcePopup;
		if (this.SID == "" || this.Token == "" || this.Auth == "" || refreshAuth == true) {
            WebClient readerClient = new WebClient();
			if (useProxy) {
				readerClient.Proxy = WebRequest.GetSystemWebProxy();
				readerClient.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
			}
            readerClient.QueryString.Add("service", "reader");
            readerClient.QueryString.Add("Email", usn);
            readerClient.QueryString.Add("Passwd", pas);
            readerClient.DownloadStringCompleted += new DownloadStringCompletedEventHandler(this.readerSIDComplete);
            readerClient.DownloadStringAsync(new Uri("https://www.google.com/accounts/ClientLogin"));
        }
        else this.readerCheckFinal();
    }


    private void readerSIDComplete(Object sender, DownloadStringCompletedEventArgs e){
        Exception error = e.Error;
		if (error != null) {
			if (this.debug) {
				ReaderComplete("error", "SID error: " + error.Message);
				this.log("Reader SID error: " + error.Message);
			}
			else ReaderComplete("error", "Cannot log in");		// human readable error - for tray icon tooltip
		}
		else {
			if (this.debug) this.log("Reader SID success.");
			String result = e.Result;
			this.SID = result.Substring(0, result.IndexOf("\n")).Trim();
			this.Auth = "GoogleLogin auth=" + result.Substring(result.IndexOf("Auth=") + 5).Trim();

			WebClient readerClient = new WebClient();
			if (useProxy) {
				readerClient.Proxy = WebRequest.GetSystemWebProxy();
				readerClient.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
			}
			readerClient.Headers.Add("Cookie", this.SID);
			readerClient.Headers.Add("Authorization", this.Auth);
			readerClient.DownloadStringCompleted += new DownloadStringCompletedEventHandler(this.readerTokenComplete);
			readerClient.DownloadStringAsync(new Uri("http://www.google.com/reader/api/0/token"));
		}
    }

    private void readerTokenComplete(Object sender, DownloadStringCompletedEventArgs e){
        Exception error = e.Error;
		if (error != null) {
			ReaderComplete("error", "Token error: " + error.Message);
			if (this.debug) this.log("Reader Token error: " + error.Message);
		}
		else {
			if (this.debug) this.log("Reader Token success.");
			String result = e.Result;
			this.Token = "T=" + result;
			this.readerCheckFinal();
		}
    }

    private void readerCheckFinal(){
        WebClient readerClient = new WebClient();
		if (useProxy) {
			readerClient.Proxy = WebRequest.GetSystemWebProxy();
			readerClient.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
		}
		readerClient.Headers.Add("Cookie", this.SID + ";" + this.Token);
        readerClient.Headers.Add("Authorization", this.Auth);
        readerClient.DownloadDataCompleted += new DownloadDataCompletedEventHandler(this.readerComplete);
        readerClient.DownloadDataAsync(new Uri("https://www.google.com/reader/api/0/unread-count?output=xml"));
    }

    private void readerComplete(Object sender, DownloadDataCompletedEventArgs e)
    {
        Exception error = e.Error;
		if (error != null) {
			ReaderComplete("error", "Final error: " + error.Message);
			if (this.debug) this.log("Reader Final error: " + error.Message);
		}
		else {
			XmlNodeList list;
			XmlDocument xmlDoc = new XmlDocument();
			byte[] result = e.Result;
			String response = Encoding.UTF8.GetString(result);

			xmlDoc.LoadXml(response);
			list = xmlDoc.SelectNodes("/object/list/object");

			this.readerTempCount = 0;

			if (list.Count > 0) {
				foreach (XmlNode node in list) {
					string id = "";
					id = node.ChildNodes[0].InnerText;
					if (id.IndexOf("com.google/reading-list") > -1) {
						this.readerTempCount = int.Parse(node.ChildNodes[1].InnerText);
						break;
					}
				}
			}
			else this.readerTempCount = 0;

			String retVal="";
			if (this.readerTempCount == 0) retVal = "0";
			else retVal=this.readerTempCount.ToString();

			if (((this.readerCount != this.readerTempCount) && this.readerTempCount > 0) || this.readerForcePopup) showPopup("reader", retVal);
			ReaderComplete("success", retVal);
			if (this.debug) this.log("Reader Final success, parse complete. Count: " + retVal);

			this.readerCount = this.readerTempCount;
		}
    }

    #endregion google reader


	private void log(String text) {
		System.IO.TextWriter tw = new System.IO.StreamWriter(this.errorLog, true);
		tw.WriteLine(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString() + " " + text);
		tw.Close();
	}
}
