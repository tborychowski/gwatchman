using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Globalization;
using System.IO;
using System.Reflection;
using Growl.Connector;

namespace GWatchNS
{
	public partial class Popup : Form {

		#region Vars /***********************************************************************************************************************/
		private Locale lang;

		private Google myGoogle = new Google();
		private Timer gmailTicker = new Timer();
		private Timer readerTicker = new Timer();
		private Timer autoHideTicker = new Timer();

		private Timer trayAnimationTimer = new Timer();
		private int currentTrayIcon = 0;
		private int mailItemsCount = 0;
		private int readerItemsCount = 0;

		private settingsForm settingsWindow;
		public SettingsMgr SettingsMgr = new SettingsMgr();	// class  from Settings.cs
		public Settings AppSettings;						// struct from Settings.cs

		public delegate void SettingsHandler();

		private String[] appArgs;
		private Boolean silentStart = false;
		private Boolean silentUpdate = false;

		private Boolean growlAvailable = false;
		private Boolean growlRunning = false;
		private GrowlConnector growl;
		private Growl.Connector.Application growlApp;
		private NotificationType growlNotifyMail, growlNotifyReader;

		#endregion Vars /********************************************************************************************************************/



		#region Init /***********************************************************************************************************************/

		public Popup(String[] args){
			this.appArgs = args;
            InitializeComponent();
        }

        private void GWatch_Load(object sender, EventArgs e){
			this.initEvents();
			this.SettingsChanged_Handler(true);
        }
		#endregion Init /*******************************************************************************************************************/



		#region Growl /**********************************************************************************************************************/
		private Boolean checkGrowlLibraries() { return (File.Exists("Growl.Connector.dll") && File.Exists("Growl.CoreLibrary.dll")); }

		private void growlInit() {
			this.growlAvailable = this.checkGrowlLibraries();										// check if files are available
			if (this.growlAvailable) this.growlRunning = GrowlConnector.IsGrowlRunningLocally();	// check if growl is running
		}


		private void growlRegister(Boolean silent=false){
			if (this.growlAvailable == false) return;						// if growl is unavailable - exit;
			if (AppSettings.alert_action_Growl.ToLower() == "true") {
				if (this.growlRunning == false) {
					if (silent == false) MessageBox.Show("Growl is not running!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else {	// Init GROWL
					try {
						this.growl = new GrowlConnector();
						// growl application
						this.growlApp = new Growl.Connector.Application("GWatchman");
						this.growlApp.Icon = Properties.Resources.google32;
						// notification types
						this.growlNotifyMail = new NotificationType("mail", "Google Mail", Properties.Resources.gmail, true);
						this.growlNotifyReader = new NotificationType("reader", "Google Reader", Properties.Resources.reader, true);
						// register
						this.growl.Register(growlApp, new NotificationType[] { growlNotifyMail, growlNotifyReader });
					}
					finally { }
				}
			}
		}

		private void growlNotify(string type, string msg){
			if (this.growlAvailable == false) return;						// if growl is unavailable - exit;

			Notification note;
			String notName="", dispName="";
			CallbackContext context = new CallbackContext("http://google.com");

			if (this.growlRunning == false) this.growlRegister(true);

			if (this.growlRunning == true) {
				if (type == "mail") {
					notName = this.growlNotifyMail.Name;
					dispName="Google Mail";
					context = new CallbackContext("https://mail.google.com/mail");
				}
				if (type == "reader") {
					notName = this.growlNotifyReader.Name;
					dispName = "Google Reader";
					context = new CallbackContext("http://www.google.com/reader");
				}

				note = new Notification(this.growlApp.Name, notName, DateTime.Now.Ticks.ToString(), dispName, msg);
				this.growl.Notify(note, context);
			}
		}

		#endregion Growl /*******************************************************************************************************************/



		#region General functions /**********************************************************************************************************/

		private void initEvents() {
			if (this.appArgs.Length > 0) foreach (string arg in this.appArgs) {
					if (arg.Substring(1) == "autorun") this.silentStart = true;		// wont show "Growl not running" warning
					if (arg.Substring(1) == "debug") this.myGoogle.debug = true;			// will generate GWatch.log
					if (arg.Substring(1) == "proxy") this.myGoogle.useProxy = true;		// will generate GWatch.log
				}

			this.autoHideTicker.Interval = 1000;
			this.autoHideTicker.Tick += new System.EventHandler(this.autoHideTicker_Tick);
			this.autoHideTicker.Enabled = true;

			this.trayAnimationTimer.Tick += new System.EventHandler(this.doTrayAnimation);

			this.gmailTicker.Tick += new System.EventHandler(this.gmailTicker_Tick);
			this.readerTicker.Tick += new System.EventHandler(this.readerTicker_Tick);
			myGoogle.showPopup += new Google.CheckHandler(showPopup_Handler);
			myGoogle.MailComplete += new Google.CheckHandler(mail_CheckComplete);
			myGoogle.ReaderComplete += new Google.CheckHandler(reader_CheckComplete);

			// init GROWL
			try { this.growlInit(); }
			catch (Exception er) { this.growlAvailable = false; }
		}

		public void exitHandler(){ this.trayIcon.Dispose(); System.Windows.Forms.Application.Exit(); }

		public void showHideHandler() { if (WindowState == FormWindowState.Minimized) this.showHandler(); else this.hideHandler(); }

		public void showHandler(){
			int dismissDelay = 3000;

			if (AppSettings.alert_DismissDelay.Length > 0) {
				if (AppSettings.alert_DismissDelay.IndexOf(',') > -1) AppSettings.alert_DismissDelay = AppSettings.alert_DismissDelay.Replace(',', '.');
				if (AppSettings.alert_DismissDelay.IndexOf('.') > -1) {
					String[] strAr = AppSettings.alert_DismissDelay.Split('.');
					AppSettings.alert_DismissDelay = strAr[0];
				}
				dismissDelay = int.Parse(AppSettings.alert_DismissDelay);
			}

			WindowState = FormWindowState.Normal;
			this.Show();
			double targetO = Convert.ToDouble(AppSettings.alert_Opacity) / 100;

			while (this.Opacity < targetO) {
				this.Invalidate();
				System.Windows.Forms.Application.DoEvents();
				System.Threading.Thread.Sleep(20);
				this.Opacity += 0.1;
			}
			
			if (dismissDelay > 0) {
				this.autoHideTicker.Interval = dismissDelay;
				this.autoHideTicker.Enabled = true;
			}
		}

        public void hideHandler(){
			while (this.Opacity > 0) {
				this.Invalidate();
				System.Windows.Forms.Application.DoEvents();
				System.Threading.Thread.Sleep(30);
				this.Opacity -= 0.1;
			}
			Hide();
			WindowState = FormWindowState.Minimized;
			this.autoHideTicker.Enabled = false;
		}
        private void GWatch_FormClosing(object sender, FormClosingEventArgs e) { this.exitHandler(); }

        private void GWatch_Resize(object sender, EventArgs e){ if (FormWindowState.Minimized == WindowState) this.hideHandler(); }
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e){ this.openSettings(); }

		
		// When form dragged with mouse
		private void GWatch_ResizeEnd(object sender, EventArgs e) {
			AppSettings.alert_posH = this.Location.X.ToString();
			AppSettings.alert_posV = this.Location.Y.ToString();
			SettingsMgr.save(AppSettings);
			if (this.settingsWindow != null) {
				this.settingsWindow.AppSettings = AppSettings;
				this.settingsWindow.SettingsToControls(AppSettings);
			}
		}

		// Autohide
		private void autoHideTicker_Tick(object sender, EventArgs e) { if (!this.ClientRectangle.Contains(this.PointToClient(Cursor.Position))) this.hideHandler(); }

		// hide action link
		private void hideActionLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) { this.hideHandler(); }

		//showpopup event
		private void showPopup_Handler(string status, string message){
			if (AppSettings.alert_action_Popup.ToLower() == "true") this.showHandler(); else this.hideHandler();
			if (this.growlAvailable && AppSettings.alert_action_Growl.ToLower() == "true") {
				if (status == "reader") this.growlNotify("reader", reader_int_to_message(message));	// "You have " + message + " unread feeds";
				else if (status == "mail") this.growlNotify("mail", mail_int_to_message(message));	// "You have " + message + " unread messages"
			}
		}

		#endregion General Functions /*******************************************************************************************************/



		#region Settings /*******************************************************************************************************************/

		private void openSettings(String tab="") {
			if (this.settingsWindow != null) if (this.settingsWindow.Visible == true) return;
			this.settingsWindow = new settingsForm();
			this.settingsWindow.SettingsChanged += new SettingsHandler(SettingsChanged_Handler);
			this.settingsWindow.AppSettings = AppSettings;
			this.settingsWindow.initTab = tab;
			this.settingsWindow.growlCheckboxAvailable(this.growlAvailable);
			this.settingsWindow.Show();
		}

		private void SettingsChanged_Handler() { SettingsChanged_Handler(false); }
		private void SettingsChanged_Handler(bool appinit = false) {
			if (this.settingsWindow != null) AppSettings = this.settingsWindow.AppSettings;
			else AppSettings = SettingsMgr.read();

			//init language
			lang = new Locale(AppSettings.general_Lang);
			this.applyLanguageStrings(lang);


			// set background
			Image bimg;
			String fpath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\background\\";
			String fbg = fpath + AppSettings.alert_Image;
			if (System.IO.File.Exists(fbg)) bimg = Image.FromFile(fbg);
			else bimg = Properties.Resources.bg;

			this.BackgroundImage = bimg;
			this.Width = bimg.Width;
			this.Height = bimg.Height;
			
			// position
			position(AppSettings.alert_posH, AppSettings.alert_posV, bimg.Width, bimg.Height);
			this.Opacity = Convert.ToDouble(AppSettings.alert_Opacity) / 100;

			// set text color
			this.readerLabel.ForeColor = System.Drawing.ColorTranslator.FromHtml(AppSettings.alert_Color);
			this.mailLabel.ForeColor = System.Drawing.ColorTranslator.FromHtml(AppSettings.alert_Color);

			
			// init Growl
			if (this.growlAvailable) this.growlRegister(this.silentStart);

			// gmail
			if (AppSettings.account_MailOn.ToLower() == "true") {
				this.mailPanel.Show();
				int mailFreq = Convert.ToInt16(AppSettings.account_MailFreq);
				this.gmailTicker.Interval = valToInterval(mailFreq);
				this.gmailTicker.Enabled = (mailFreq > 0);
				this.gmailCheck(true);
			}
			else {
				this.mailItemsCount = 0;
				this.mailPanel.Hide();
			}

			// reader
			if (AppSettings.account_ReaderOn.ToLower() == "true") {
				this.readerPanel.Show();
				int readerFreq = Convert.ToInt16(AppSettings.account_ReaderFreq);
				this.readerTicker.Interval = valToInterval(readerFreq);
				this.readerTicker.Enabled = (readerFreq > 0);
				this.readerCheck(true, true);
			}
			else {
				this.readerItemsCount = 0;
				this.readerPanel.Hide();
			}

			// do this on application start
			if (appinit == true) {
				// if one of those is empty - open settings dialog
				if (AppSettings.account_Username == "" || AppSettings.account_Password=="") this.openSettings();
			}

			AppSettings.version = this.getVersion();
			if (AppSettings.alert_action_Popup.ToLower() == "false") this.hideHandler();
			if (AppSettings.general_updateOnStart.ToLower() == "true") this.checkForUpdates();
		}


		// apply lang strings
		private void applyLanguageStrings(Locale lang) {
			// main form
			hideActionLink.Text = lang.getString("hide");
			Tooltip.SetToolTip(hideActionLink, lang.getString("hideLinkTip"));
			Tooltip.SetToolTip(readerLabel, lang.getString("readerLabelTip"));
			Tooltip.SetToolTip(readerLogo, lang.getString("readerLogoTip"));
			Tooltip.SetToolTip(mailLabel, lang.getString("mailLabelTip"));
			Tooltip.SetToolTip(mailLogo, lang.getString("mailLogoTip"));

			// tray menu
			trayMenuCheck.Text = lang.getString("show");
			trayMenuSettings.Text = lang.getString("settings");
			trayMenuUpdate.Text = lang.getString("update");
			trayMenuAbout.Text = lang.getString("about");
			trayMenuQuit.Text = lang.getString("exit");
		}


		private void position(string sX, string sY, int winW, int winH) {
			int x, y;
			Rectangle scr = SystemInformation.WorkingArea;	//SystemInformation.WorkingArea {X=0,Y=22,Width=1680,Height=988}
			switch (sX.ToLower()) {
				case "left": x = scr.X; break;
				case "center": x = (scr.Width - winW) / 2; break;
				case "right": x = scr.X + scr.Width - winW; break;
				default: x = Convert.ToInt16(sX); break;
			}
			switch (sY.ToLower()) {
				case "top": y = scr.Y; break;
				case "middle": y = (scr.Height - winH) / 2; break;
				case "bottom": y = scr.Y + scr.Height - winH; break;
				default: y = Convert.ToInt16(sY); break;
			}
			this.Location = new Point(x, y);
		}

		private int valToInterval(int val) {
			int interval;
			switch (val) {
				case 9: interval = 10800000; break; // 3 hour
				case 8: interval = 3600000; break;  // 1 hour
				case 7: interval = 1800000; break;  // 30 min
				case 6: interval = 900000; break;   // 15 min
				case 5: interval = 600000; break;   // 10 min
				case 4: interval = 300000; break;   // 5 min
				case 3: interval = 120000; break;   // 2 min
				case 2: interval = 60000; break;    // 1 min
				case 1: interval = 30000; break;    // 30s
				case 0: interval = 1; break;
				default: interval = 1; break;
			}
			return interval;
		}

		#endregion Settings /****************************************************************************************************************/



		#region Gmail /**********************************************************************************************************************/

		public void gmailCheck(bool forcePopup = false) {
			this.mailLabel.Text = "0";
			this.mailLoader.Visible = true;
			this.startTrayAnimation();
			myGoogle.gmailCheck(AppSettings.account_Username, AppSettings.account_Password, forcePopup); 
		}

		private void mail_CheckComplete(string status, string message) {
			this.stopTrayAnimation();
			if (status == "error") {
				this.mailLabel.Text = message;
				this.showTrayError(message);
			}
			else {
				this.mailLabel.Text = mail_int_to_message(message);	// "You have " + message + " unread feeds";
				if ((this.mailItemsCount + this.readerItemsCount) > 0) this.showTrayStar();
			}
			this.mailLoader.Visible = false;
		}
		
		private String mail_int_to_message(String sMsg) {
			string outMsg = "";
			this.mailItemsCount = int.Parse(sMsg);
			if (this.mailItemsCount == 1) outMsg = this.lang.getString("oneMessageAlert");
			else outMsg = this.lang.getString("manyMessagesAlert");
			return outMsg.Replace("%n", sMsg); // "You have " + message + " unread messages";
		}
        private void gmailLabel_Click(object sender, EventArgs e){ this.gmailCheck(); }
        private void gmailImg_Click(object sender, EventArgs e) { System.Diagnostics.Process.Start("https://mail.google.com/mail/?shva=1"); }
        private void gmailTicker_Tick(object sender, EventArgs e) { this.gmailCheck(); }

		#endregion Gmail /*******************************************************************************************************************/



		#region Google reader /**************************************************************************************************************/

		public void readerCheck(bool refreshAuth = false, bool forcePopup = false) {
			this.readerLabel.Text = "0";
			this.readerLoader.Visible = true;
			this.startTrayAnimation();
			myGoogle.readerCheck(AppSettings.account_Username, AppSettings.account_Password, refreshAuth, forcePopup); 
		}

		private void reader_CheckComplete(string status, string message) {
			this.stopTrayAnimation();
			if (status == "error") {
				this.readerLabel.Text = message;
				this.showTrayError(message);
			}
			else {
				this.readerLabel.Text = reader_int_to_message(message);	// "You have " + message + " unread feeds";
				if ((this.mailItemsCount + this.readerItemsCount) > 0) this.showTrayStar();
			}
			this.readerLoader.Visible = false;
		}

		private String reader_int_to_message(String sMsg) {
			String outMsg = "";
			this.readerItemsCount = int.Parse(sMsg);
			if (this.readerItemsCount == 1) outMsg = this.lang.getString("oneFeedAlert");
			else outMsg = this.lang.getString("manyFeedsAlert");
			return outMsg.Replace("%n", sMsg); // "You have " + message + " unread feeds";

		}
        private void readerLabel_Click(object sender, EventArgs e){ this.readerCheck(); }
        private void readerImg_Click(object sender, EventArgs e) { System.Diagnostics.Process.Start("http://www.google.com/reader/view"); }
        private void readerTicker_Tick(object sender, EventArgs e) { this.readerCheck(); }

		#endregion Reader /******************************************************************************************************************/



		#region Tray icon/menu handling /****************************************************************************************************/

		private void trayIcon_MouseClick(object sender, MouseEventArgs e) {
			if (e.Button == MouseButtons.Left) {
				if (this.growlAvailable) { if (this.growlRunning == false) this.growlRegister(false); }
				if (AppSettings.account_MailOn.ToLower() == "true") this.gmailCheck(true);
				if (AppSettings.account_ReaderOn.ToLower() == "true") this.readerCheck(false, true);
			}
		}
		private void trayIcon_MouseDoubleClick(object sender, MouseEventArgs e) { this.openSettings(); }

		private void trayCheckNow_Click(object sender, EventArgs e) { this.gmailCheck(true); this.readerCheck(false, true); }
		private void trayCheckForUpdates_Click(object sender, EventArgs e) { this.checkForUpdates(false); }
		private void trayAbout_Click(object sender, EventArgs e) { this.openSettings("About"); }
		private void trayQuit_Click(object sender, EventArgs e) { this.exitHandler(); }

		#endregion Tray /********************************************************************************************************************/



		#region Tray Icon Manipulation /*****************************************************************************************************/

		private void startTrayAnimation(){
			this.currentTrayIcon = 1;
			this.trayAnimationTimer.Interval = 40;
			this.trayAnimationTimer.Enabled = true;
			this.trayIcon.Text = "Checking...";
		}

		private void doTrayAnimation(object sender, EventArgs e){ this.doTrayAnimation(); }
		private void doTrayAnimation() {
			try {
				Icon img = (Icon)Properties.Resources.ResourceManager.GetObject("g" + this.currentTrayIcon.ToString());
				this.trayIcon.Icon = img;
				if (this.currentTrayIcon < 8) this.currentTrayIcon++; else this.currentTrayIcon = 1;
			}
			catch (Exception e) { }
		}

		private void stopTrayAnimation() {
			this.trayAnimationTimer.Enabled = false;
			this.currentTrayIcon = 1;
			this.doTrayAnimation();
			//this.trayIcon.Text = mail_int_to_message(this.mailItemsCount.ToString()) + "\n" + reader_int_to_message(this.readerItemsCount.ToString());
			string trayText = "";
			bool isMail = (AppSettings.account_MailOn.ToLower() == "true"), isReader=(AppSettings.account_ReaderOn.ToLower() == "true");
			if (isMail) trayText = "Mail: " + this.mailItemsCount.ToString();
			if (isMail && isReader) trayText += "\n";
			if (isReader) trayText += "Reader: " + this.readerItemsCount.ToString();
			this.trayIcon.Text =  trayText;
		}

		private void showTrayError(string message) {
			if (message.Length > 50) message = message.Substring(0, 50);	// Text length must be less than 64 characters long
			Icon img = (Icon)Properties.Resources.ResourceManager.GetObject("error");
			this.trayIcon.Icon = img;
			this.trayIcon.Text = "Error\n"+message;
		}

		private void showTrayStar() {
			Icon img = (Icon)Properties.Resources.ResourceManager.GetObject("star");
			this.trayIcon.Icon = img;
			//this.trayIcon.Text = mail_int_to_message(this.mailItemsCount.ToString()) + "\n" + reader_int_to_message(this.readerItemsCount.ToString());
			string trayText = "";
			bool isMail = (AppSettings.account_MailOn.ToLower() == "true"), isReader = (AppSettings.account_ReaderOn.ToLower() == "true");
			if (isMail) trayText = "Mail: " + this.mailItemsCount.ToString();
			if (isMail && isReader) trayText += "\n";
			if (isReader) trayText += "Reader: " + this.readerItemsCount.ToString();
			this.trayIcon.Text = trayText;
		}

		#endregion /*************************************************************************************************************************/



		#region Update and Version /*********************************************************************************************************/

		private String getVersion() {
			Version version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
			return version.ToString();
		}

		private void checkForUpdates(Boolean silent = true){
			this.silentUpdate = silent;
			System.Net.WebClient client = new System.Net.WebClient();
			client.DownloadDataCompleted += new System.Net.DownloadDataCompletedEventHandler(this.checkLatestVersionComplete);
			client.DownloadDataAsync(new Uri("http://gwatchman.googlecode.com/svn/update/latest.xml"));
		}
		private void checkLatestVersionComplete(Object sender, System.Net.DownloadDataCompletedEventArgs e) {
			Exception error = e.Error;
			if (error != null) {}
			else {
				System.Xml.XmlNode node;
				System.Xml.XmlDocument xmlDoc = new System.Xml.XmlDocument();
				byte[] result = e.Result;
				String response = Encoding.UTF8.GetString(result);
				String downloadURL = "", newVer = "", curVer = this.getVersion();

				xmlDoc.LoadXml(response);
				node = xmlDoc.SelectSingleNode("/update/version");
				if (node != null) {
					newVer = node.InnerText;
					node = xmlDoc.SelectSingleNode("/update/download");
					if (node != null) downloadURL = node.InnerText;
				}


				// Show Dialog
				String title, msg;
				int iCurVer = int.Parse(curVer.Replace(".", "")), iNewVer = int.Parse(newVer.Replace(".", ""));
				// compare version strings converted to numbers, i.e.: 1.0.5.1 -> 1051
				if (iCurVer < iNewVer) {
					title = lang.getString("updateAvailableTitle");
					msg = lang.getString("updateAvailable")+"\n"+
						  lang.getString("yourVersion")+": "+curVer+"\n"+
						  lang.getString("latestVersion")+": "+newVer+"\n\n"+
						  lang.getString("downloadLatestQuestion");

					if (DialogResult.Yes == MessageBox.Show(msg, title, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)) 
						System.Diagnostics.Process.Start(downloadURL);		// if YES - open download file in browser
				}
				else {
					if (this.silentUpdate == false) 
						MessageBox.Show(lang.getString("updateNotAvailableMsg"), lang.getString("updateNotAvailableTitle"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
			}

		}


		#endregion /*************************************************************************************************************************/




		#region mouse handling

		// mouse enter/leave
		private void panel_MouseEnter(object sender, EventArgs e) { this.autoHideTicker.Enabled = false; }
		private void panel_MouseLeave(object sender, EventArgs e) { if (!this.ClientRectangle.Contains(this.PointToClient(Cursor.Position))) this.hideHandler(); }

		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[DllImportAttribute("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		[DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();

		private void panel_MouseDown(object sender, MouseEventArgs e) { 
			if (e.Button == MouseButtons.Left) { 
				ReleaseCapture(); 
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); 
			} 
		}

		#endregion

    }



}
