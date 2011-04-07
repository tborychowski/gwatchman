using System;
using System.Xml;

namespace GWatchNS {

    public struct Settings{
		public String account_Username;
		public String account_Password;
		public String account_UsernameSave;
		public String account_PasswordSave;
		public String account_MailFreq;
		public String account_MailOn;
		public String account_ReaderFreq;
		public String account_ReaderOn;

		public String general_Lang;
		public String general_updateOnStart;

		public String alert_action_Popup;
		public String alert_action_Growl;

		public String alert_posV;
		public String alert_posH;
		public String alert_Opacity;
		public String alert_Image;
		public String alert_Color;
		public String alert_DismissDelay;

		public String version;
	}

    public class SettingsMgr{
        XmlDocument xmlDoc = new XmlDocument();
		XmlNode temp;
		XmlAttribute tempA;
		Settings conf;
		String settingsFileName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\GWatch.xml";
	    string passcode = "G00glŁ@czmen";

		public Settings read() {
			try {
				if (System.IO.File.Exists(settingsFileName)) xmlDoc.Load(settingsFileName);
				else throw new XmlException("Settings file not found");
			}
			catch (XmlException e) { }
			finally { conf = setDefaultSettings(); }


			if (xmlDoc != null) {

				#region READ ACCOUNT SETTINGS
				XmlNode account = xmlDoc.SelectSingleNode("/settings/account");
				if (account != null) {

					temp = account.SelectSingleNode("username");
					if (temp != null) {
						conf.account_Username = temp.InnerText;
						tempA = temp.Attributes["save"];
						if (tempA != null) conf.account_UsernameSave = tempA.Value;
					}

					temp = account.SelectSingleNode("password");
					if (temp != null) {
						conf.account_Password = Crypter.DecryptString(temp.InnerText, passcode);
						tempA = temp.Attributes["save"];
						if (tempA != null) conf.account_PasswordSave = tempA.Value;
					}

					temp = account.SelectSingleNode("mail");
					if (temp != null) {
						tempA = temp.Attributes["check"];
						if (tempA != null) conf.account_MailOn = tempA.Value;
						tempA = temp.Attributes["freq"];
						if (tempA != null) conf.account_MailFreq = tempA.Value;
					}

					temp = account.SelectSingleNode("reader");
					if (temp != null) {
						tempA = temp.Attributes["check"];
						if (tempA != null) conf.account_ReaderOn = tempA.Value;
						tempA = temp.Attributes["freq"];
						if (tempA != null) conf.account_ReaderFreq = tempA.Value;
					}
				}
				#endregion


				#region READ GENERAL SETTINGS
				XmlNode general = xmlDoc.SelectSingleNode("/settings/general");
				if (general != null) {
					temp = general.SelectSingleNode("lang");
					if (temp != null) conf.general_Lang = temp.InnerText;

					temp = general.SelectSingleNode("updateOnStart");
					if (temp != null) conf.general_updateOnStart = temp.InnerText;
				}
				#endregion


				#region READ ALERT SETTINGS
				XmlNode alert = xmlDoc.SelectSingleNode("/settings/alert");
				if (alert != null) {
					temp = alert.SelectSingleNode("layout/horiz");
					if (temp != null) conf.alert_posH = temp.InnerText;

					temp = alert.SelectSingleNode("layout/vert");
					if (temp != null) conf.alert_posV = temp.InnerText;

					temp = alert.SelectSingleNode("layout/opacity");
					if (temp != null) conf.alert_Opacity = temp.InnerText;

					temp = alert.SelectSingleNode("layout/image");
					if (temp != null) conf.alert_Image = temp.InnerText;

					temp = alert.SelectSingleNode("layout/color");
					if (temp != null) conf.alert_Color = temp.InnerText;

					temp = alert.SelectSingleNode("layout/dismissDelay");
					if (temp != null) conf.alert_DismissDelay = temp.InnerText;
					if (conf.alert_DismissDelay.Length > 0) {
						conf.alert_DismissDelay = conf.alert_DismissDelay.Replace(',', '.');
						String[] strAr = conf.alert_DismissDelay.Split('.');
						conf.alert_DismissDelay = strAr[0];
					}

					temp = alert.SelectSingleNode("action/popup");
					if (temp != null) conf.alert_action_Popup = temp.InnerText;

					temp = alert.SelectSingleNode("action/growl");
					if (temp != null) conf.alert_action_Growl = temp.InnerText;
				}
				#endregion
			}
			return conf;
		}

		private Settings setDefaultSettings() {
			Settings conf;
			conf.account_Username = "";
			conf.account_UsernameSave = "false";
			conf.account_Password = "";
			conf.account_PasswordSave = "false";
			conf.account_MailFreq = "0";
			conf.account_MailOn = "true";
			conf.account_ReaderFreq = "0";
			conf.account_ReaderOn = "true";
			conf.general_Lang = "english";
			conf.general_updateOnStart = "true";
			conf.alert_action_Popup = "true";
			conf.alert_action_Growl = "false";
			conf.alert_posH = "right";
			conf.alert_posV = "bottom";
			conf.alert_Opacity = "100";
			conf.alert_Color = "#fff";
			conf.alert_Image = "";
			conf.alert_DismissDelay = "3";
			conf.version = "0";
			return conf;
		}

		public void save(Settings conf) {
			string encPass = "";

			if (conf.account_UsernameSave != "true") conf.account_Username = "";
			if (conf.account_PasswordSave == "true" && conf.account_Password.Length > 0) encPass = Crypter.EncryptString(conf.account_Password, passcode);
			else encPass = "";

			XmlTextWriter writer = new XmlTextWriter(settingsFileName, System.Text.Encoding.UTF8);
			writer.WriteStartDocument();
			writer.WriteRaw("\n<settings>\n");
			// account
				writer.WriteRaw("	<account>\n");
					writer.WriteRaw("		<username save=\"" + conf.account_UsernameSave + "\">" + conf.account_Username + "</username>\n");
					writer.WriteRaw("		<password save=\"" + conf.account_PasswordSave + "\">" + encPass + "</password>\n");
					writer.WriteRaw("		<mail check=\"" + conf.account_MailOn + "\" freq=\"" + conf.account_MailFreq + "\" />\n");
					writer.WriteRaw("		<reader check=\"" + conf.account_ReaderOn + "\" freq=\"" + conf.account_ReaderFreq + "\" />\n");
				writer.WriteRaw("	</account>\n");

			// general
				writer.WriteRaw("	<general>\n");
					writer.WriteRaw("		<lang>" + conf.general_Lang + "</lang>\n");
					writer.WriteRaw("		<updateOnStart>" + conf.general_updateOnStart + "</updateOnStart>\n");
				writer.WriteRaw("	</general>\n");

			// alert
				writer.WriteRaw("	<alert>\n");
					writer.WriteRaw("		<layout>\n");
						writer.WriteRaw("			<vert>" + conf.alert_posV + "</vert>\n");
						writer.WriteRaw("			<horiz>" + conf.alert_posH + "</horiz>\n");
						writer.WriteRaw("			<opacity>" + conf.alert_Opacity + "</opacity>\n");
						writer.WriteRaw("			<image>" + conf.alert_Image + "</image>\n");
						writer.WriteRaw("			<color>" + conf.alert_Color + "</color>\n");
						writer.WriteRaw("			<dismissDelay>" + conf.alert_DismissDelay + "</dismissDelay>\n");
					writer.WriteRaw("		</layout>\n");
					writer.WriteRaw("		<action>\n");
						writer.WriteRaw("			<popup>" + conf.alert_action_Popup + "</popup>\n");
						writer.WriteRaw("			<growl>" + conf.alert_action_Growl + "</growl>\n");
					writer.WriteRaw("		</action>\n");
				writer.WriteRaw("	</alert>\n");
			writer.WriteRaw("</settings>");
			writer.Close();  
		}

    }
}

