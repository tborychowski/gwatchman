using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace GWatchNS {

    public partial class settingsForm : Form {

		#region Init
		[System.Runtime.InteropServices.DllImport("uxtheme", CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
		public extern static Int32 SetWindowTheme(IntPtr hWnd, String textSubAppName, String textSubIdList);

		public SettingsMgr SettingsMgr;	// class
		public Settings AppSettings;	// struct
		public String initTab;
		public event Popup.SettingsHandler SettingsChanged;
		private Locale lang;

		
		public settingsForm() { 
			InitializeComponent(); 
		}

        private void settingsForm_Load(object sender, EventArgs e){
			SetWindowTheme(this.settingsTree.Handle, "explorer", null);		// enable aero theme for tree view

			SettingsMgr = new SettingsMgr();
	
			//init language
			lang = new Locale(AppSettings.general_Lang);
			this.applyLanguageStrings(lang);

			this.SettingsToControls(AppSettings);
			
			string selNode;
			if (this.initTab!="") selNode = "settingsTreeNode"+initTab;
			else selNode = "settingsTreeNodeAccounts";

			this.switchSettingsPanel(selNode);
			this.settingsTree.SelectedNode = settingsTree.Nodes[selNode];
			this.settingsTree.Select();
		}

		#endregion Init


		#region settings <> controls

		public void SettingsToControls(Settings conf) {
			// account
			settingsUsernameTextBox.Text = conf.account_Username;
			settingsUsernameSaveChbox.Checked = (conf.account_UsernameSave.ToLower() == "true");
			settingsPassTextBox.Text = conf.account_Password;
			settingsPassSaveChbox.Checked = (conf.account_PasswordSave.ToLower() == "true");

			settingsMailFreqBar.Value = Byte.Parse(conf.account_MailFreq);
			settingsMailFreqLabel.Text = this.valToStr(settingsMailFreqBar.Value);
			settingsMailToggler.Checked = (conf.account_MailOn.ToLower() == "true");

			settingsReaderFreqBar.Value = Byte.Parse(conf.account_ReaderFreq);
			settingsReaderFreqLabel.Text = this.valToStr(settingsReaderFreqBar.Value);
			settingsReaderToggler.Checked = (conf.account_ReaderOn.ToLower() == "true");

			// general
			settingsAutoStartCheckbox.Checked = AutoStart.IsAutoStartEnabled;
			settingsUpdateOnStartCheckbox.Checked = (conf.general_updateOnStart.ToLower() == "true");
			settingsLangCombo.SelectedIndex = settingsLangCombo.FindString(conf.general_Lang);

			// read language files from folder
			settingsLangCombo.Items.Clear();
			settingsLangCombo.Items.Add("English (Default)");
			settingsLangCombo.SelectedIndex = 0;
			String langFolder = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\lang\\";
			if (System.IO.Directory.Exists(langFolder)) {
				DirectoryInfo dirInfo = new DirectoryInfo(langFolder);
				FileInfo[] files;
				files = dirInfo.GetFiles("*.xml");
				foreach (FileInfo fi in files) {
					string fname = Path.GetFileNameWithoutExtension(fi.Name);
					if (fname.ToLower() != "english") settingsLangCombo.Items.Add(fname);
				}
				if (conf.general_Lang.Length > 0) settingsLangCombo.SelectedIndex = settingsLangCombo.FindString(conf.general_Lang);
			}

			// alert
			if (conf.alert_posV != "") switch (conf.alert_posV.ToLower()) {
					case "top": settingsAlertVerticalCombo.SelectedIndex = 0; break;
					case "middle": settingsAlertVerticalCombo.SelectedIndex = 1; break;
					case "bottom": settingsAlertVerticalCombo.SelectedIndex = 2; break;
					default: settingsAlertVerticalCombo.SelectedIndex = 3; break;
				}

			if (conf.alert_posH != "") switch (conf.alert_posH.ToLower()) {
					case "left": settingsAlertHorizontalCombo.SelectedIndex = 0; break;
					case "center": settingsAlertHorizontalCombo.SelectedIndex = 1; break;
					case "right": settingsAlertHorizontalCombo.SelectedIndex = 2; break;
					default: settingsAlertHorizontalCombo.SelectedIndex = 3; break;
				}

			settingsAlertOpacityBox.Value = Byte.Parse(conf.alert_Opacity);
			settingsAlertColor.Text = conf.alert_Color;

			settingsAlertDismissDelay.Value = Decimal.Parse(conf.alert_DismissDelay);

			settingsAlertActionPopupChBox.Checked = (conf.alert_action_Popup.ToLower() == "true");
			settingsAlertActionGrowlChBox.Checked = (conf.alert_action_Growl.ToLower() == "true");

			// read background images from folder
			settingsAlertImage.Items.Clear();
			settingsAlertImage.Items.Add("Default");
			settingsAlertImage.SelectedIndex = 0;
			String bgFolder = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\background\\";
			if (System.IO.Directory.Exists(bgFolder)) {
				DirectoryInfo dirInfo = new DirectoryInfo(bgFolder);
				FileInfo[] files;
				files = dirInfo.GetFiles("*.png"); foreach (FileInfo fi in files) settingsAlertImage.Items.Add(fi.Name);
				files = dirInfo.GetFiles("*.bmp"); foreach (FileInfo fi in files) settingsAlertImage.Items.Add(fi.Name);
				files = dirInfo.GetFiles("*.jpg"); foreach (FileInfo fi in files) settingsAlertImage.Items.Add(fi.Name);
				files = dirInfo.GetFiles("*.gif"); foreach (FileInfo fi in files) settingsAlertImage.Items.Add(fi.Name);
				if (conf.alert_Image.Length > 0) settingsAlertImage.SelectedIndex = settingsAlertImage.FindString(conf.alert_Image);
			}
		}


		private Settings ControlsToSettings() {
			Settings conf = new Settings();
			conf.version = AppSettings.version;

			// account
			conf.account_Username = settingsUsernameTextBox.Text;
			conf.account_UsernameSave = settingsUsernameSaveChbox.Checked.ToString().ToLower();
			conf.account_Password = settingsPassTextBox.Text;
			conf.account_PasswordSave = settingsPassSaveChbox.Checked.ToString().ToLower();
			conf.account_MailFreq = settingsMailFreqBar.Value.ToString();
			conf.account_MailOn = settingsMailToggler.Checked.ToString().ToLower();
			conf.account_ReaderFreq = settingsReaderFreqBar.Value.ToString();
			conf.account_ReaderOn = settingsReaderToggler.Checked.ToString().ToLower();

			// general
			conf.general_Lang = settingsLangCombo.SelectedItem.ToString();
			conf.general_updateOnStart = settingsUpdateOnStartCheckbox.Checked.ToString().ToLower();

			bool isASenabled = AutoStart.IsAutoStartEnabled;
			if (settingsAutoStartCheckbox.Checked) {
				if (isASenabled == false) AutoStart.SetAutoStart();
			}
			else {
				if (isASenabled == true) AutoStart.UnSetAutoStart();
			}

			// alert

			switch (settingsAlertVerticalCombo.SelectedIndex) {
				case 0: conf.alert_posV = "top"; break;
				case 1: conf.alert_posV = "middle"; break;
				case 2: conf.alert_posV = "bottom"; break;
				default: conf.alert_posV = AppSettings.alert_posV; break;
			}

			switch (settingsAlertHorizontalCombo.SelectedIndex) {
				case 0: conf.alert_posH = "left"; break;
				case 1: conf.alert_posH = "center"; break;
				case 2: conf.alert_posH = "right"; break;
				default: conf.alert_posH = AppSettings.alert_posH; break;
			}
			
			conf.alert_Opacity = settingsAlertOpacityBox.Value.ToString();
			conf.alert_Image = settingsAlertImage.SelectedItem.ToString();
			conf.alert_Color = settingsAlertColor.Text;
			conf.alert_DismissDelay = settingsAlertDismissDelay.Value.ToString();
			conf.alert_action_Popup = settingsAlertActionPopupChBox.Checked.ToString();
			conf.alert_action_Growl = settingsAlertActionGrowlChBox.Checked.ToString();

			return conf;
		}

		#endregion settings <> controls


		#region Apply language strings

		private void applyLanguageStrings(Locale lang) {

			// window
			this.Text = "GWatchman " + AppSettings.version + " - " + lang.getString("settings");
			settingsApplyButton.Text = lang.getString("apply");
			settingsCancelButton.Text = lang.getString("close");

			// tree
			settingsTree.Nodes["settingsTreeNodeAccounts"].Text = lang.getString("account");
			settingsTree.Nodes["settingsTreeNodeAlert"].Text = lang.getString("alert");
			settingsTree.Nodes["settingsTreeNodeGeneral"].Text = lang.getString("general");
			settingsTree.Nodes["settingsTreeNodeAbout"].Text = lang.getString("about");

			// account
			settingsAccountLabel.Text = lang.getString("account");
			settingsUsernameLabel.Text = lang.getString("username");
			settingsPasswordLabel.Text = lang.getString("password");
			settingsUsernameSaveChbox.Text = lang.getString("rememberLogin");
			settingsPassSaveChbox.Text = lang.getString("rememberPassword");

			settingsMailToggler.Text = lang.getString("mail");
			settingsReaderToggler.Text = lang.getString("reader");

			this.settingsMailFreqLabel.Text = valToStr(this.settingsMailFreqBar.Value);
			this.settingsReaderFreqLabel.Text = valToStr(this.settingsReaderFreqBar.Value);

			// alert
			settingsAlertLabel.Text = lang.getString("alert");
			actionGroupBox.Text = lang.getString("action");
			settingsAlertActionPopupChBox.Text = lang.getString("nativePopup");
			nativePopupSettingsGroupBox.Text = lang.getString("nativePopupSettings");
			settingsPositionLabel.Text = lang.getString("position");

			settingsAlertVerticalCombo.Items.Clear();
			settingsAlertVerticalCombo.Items.Add(lang.getString("top"));
			settingsAlertVerticalCombo.Items.Add(lang.getString("middle"));
			settingsAlertVerticalCombo.Items.Add(lang.getString("bottom"));
			settingsAlertVerticalCombo.Items.Add(lang.getString("custom"));

			settingsAlertHorizontalCombo.Items.Clear();
			settingsAlertHorizontalCombo.Items.Add(lang.getString("left"));
			settingsAlertHorizontalCombo.Items.Add(lang.getString("center"));
			settingsAlertHorizontalCombo.Items.Add(lang.getString("right"));
			settingsAlertHorizontalCombo.Items.Add(lang.getString("custom"));			

			settingsBackgroundLabel.Text = lang.getString("background");
			settingsToolTip.SetToolTip(settingsAlertImage, lang.getString("backgroundTip").Replace("\\n","\n"));

			settingsTextColorLabel.Text = lang.getString("textColor");
			settingsToolTip.SetToolTip(settingsAlertColor, lang.getString("textColorTip") + "\n#fff, white, #000000");

			settingsOpacityLabel.Text = lang.getString("opacity");
			settingsDismissDelayLabel.Text = lang.getString("dismissDelay");


			// general
			settingsGeneralLabel.Text = lang.getString("general");
			settingsLanguageLabel.Text = lang.getString("language");
			settingsGetLanguagesLink.Text = lang.getString("getLanguages");
			settingsAutoStartCheckbox.Text = lang.getString("startWithSystem");
			settingsUpdateOnStartCheckbox.Text = lang.getString("updateOnStart");

			// about
			settingsAboutLabel.Text = lang.getString("about") + " GWatchman " + AppSettings.version;
			settingsAboutText.Text = lang.getString("aboutText").Replace("\\n","\n");
		}

		#endregion Apply language strings


		#region UI controls

		public void growlCheckboxAvailable(Boolean growlAvailable) {
			this.settingsAlertActionGrowlChBox.Enabled = growlAvailable;
		}

		public void switchSettingsPanel(String node){
            settingsPanelGeneral.Visible = false;
            settingsPanelGeneral.Dock = DockStyle.None;

            settingsPanelAccounts.Visible = false;
            settingsPanelAccounts.Dock = DockStyle.None;

			settingsPanelAlert.Visible = false;
			settingsPanelAlert.Dock = DockStyle.None;

			settingsPanelAbout.Visible = false;
			settingsPanelAbout.Dock = DockStyle.None;

            switch (node){
                case "settingsTreeNodeAccounts": settingsPanelAccounts.Visible = true; settingsPanelAccounts.Dock = DockStyle.Fill; break;
                case "settingsTreeNodeGeneral": settingsPanelGeneral.Visible = true; settingsPanelGeneral.Dock = DockStyle.Fill; break;
                case "settingsTreeNodeAlert": settingsPanelAlert.Visible = true; settingsPanelAlert.Dock = DockStyle.Fill; break;
                case "settingsTreeNodeAbout": settingsPanelAbout.Visible = true; settingsPanelAbout.Dock = DockStyle.Fill; break;
            }
        }



        private string valToStr(int val) {
            string info;
			string checkEvery = lang.getString("checkEvery");
            switch (val) {
                case 9: info = checkEvery + " 3h"; break;
                case 8: info = checkEvery + " 1h"; break;
                case 7: info = checkEvery + " 30min"; break;
                case 6: info = checkEvery + " 15min"; break;
                case 5: info = checkEvery + " 10min"; break;
                case 4: info = checkEvery + " 5min"; break;
                case 3: info = checkEvery + " 2min"; break;
                case 2: info = checkEvery + " 1min"; break;
                case 1: info = checkEvery + " 30s"; break;
                case 0:
				default: info = lang.getString("noAutoCheck"); break;
            }
            return info;
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



		private void settingsApplyButton_Click(object sender, EventArgs e) {
			AppSettings = this.ControlsToSettings();

			SettingsMgr.save(AppSettings);
			SettingsChanged();

			this.lang = new Locale(AppSettings.general_Lang);
			this.applyLanguageStrings(lang);

			this.SettingsToControls(AppSettings);
		}

		private void settingsCancelButton_Click(object sender, EventArgs e) { this.Close(); }

		private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e) { this.switchSettingsPanel(e.Node.Name); }

		private void settingsMailFreqBar_ValueChanged(object sender, EventArgs e) {
			this.settingsMailFreqLabel.Text = valToStr(this.settingsMailFreqBar.Value);
		}

		private void settingsReaderFreqBar_ValueChanged(object sender, EventArgs e) {
			this.settingsReaderFreqLabel.Text = valToStr(this.settingsReaderFreqBar.Value);
		}

		private void settingsPassSaveChbox_CheckedChanged(object sender, EventArgs e) {
			if (this.settingsPassSaveChbox.Checked) this.settingsUsernameSaveChbox.Checked = true;
			this.settingsUsernameSaveChbox.Enabled = !this.settingsPassSaveChbox.Checked;
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			System.Diagnostics.Process.Start("http://gwatchman.googlecode.com");
		}

		private void settingsGetLanguagesLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			System.Diagnostics.Process.Start("http://code.google.com/p/gwatchman/wiki/Languages");
		}


		private void settingsMailToggler_CheckedChanged(object sender, EventArgs e) {
			settingsMailFreqLabel.Enabled = settingsMailToggler.Checked;
			settingsMailFreqBar.Enabled = settingsMailToggler.Checked;
			pictureBox1.Enabled = settingsMailToggler.Checked;
		}


		private void settingsReaderToggler_CheckedChanged(object sender, EventArgs e) {
			settingsReaderFreqLabel.Enabled = settingsReaderToggler.Checked;
			settingsReaderFreqBar.Enabled = settingsReaderToggler.Checked;
			pictureBox2.Enabled = settingsReaderToggler.Checked;
		}

		private void buttonPanel_Paint(object sender, PaintEventArgs e) {
			ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.Transparent, 0, ButtonBorderStyle.None, Color.Black, 1, ButtonBorderStyle.Outset, Color.Transparent, 0, ButtonBorderStyle.None, Color.Transparent, 0, ButtonBorderStyle.None);
		}


		// panel-title-labels' bottom borders
		private void settingsAccountLabel_Paint(object sender, PaintEventArgs e) {
			ControlPaint.DrawBorder(e.Graphics, this.settingsAccountLabel.ClientRectangle,Color.Transparent, 0, ButtonBorderStyle.None,Color.Transparent, 0, ButtonBorderStyle.None,Color.Transparent, 0, ButtonBorderStyle.None,Color.Gray, 1, ButtonBorderStyle.Solid);
		}

		private void settingsAlertLabel_Paint(object sender, PaintEventArgs e) {
			ControlPaint.DrawBorder(e.Graphics, this.settingsAccountLabel.ClientRectangle, Color.Transparent, 0, ButtonBorderStyle.None, Color.Transparent, 0, ButtonBorderStyle.None, Color.Transparent, 0, ButtonBorderStyle.None, Color.Gray, 1, ButtonBorderStyle.Solid);
		}

		private void settingsAboutLabel_Paint(object sender, PaintEventArgs e) {
			ControlPaint.DrawBorder(e.Graphics, this.settingsAccountLabel.ClientRectangle, Color.Transparent, 0, ButtonBorderStyle.None, Color.Transparent, 0, ButtonBorderStyle.None, Color.Transparent, 0, ButtonBorderStyle.None, Color.Gray, 1, ButtonBorderStyle.Solid);
		}

		private void settingsGeneralLabel_Paint(object sender, PaintEventArgs e) {
			ControlPaint.DrawBorder(e.Graphics, this.settingsAccountLabel.ClientRectangle, Color.Transparent, 0, ButtonBorderStyle.None, Color.Transparent, 0, ButtonBorderStyle.None, Color.Transparent, 0, ButtonBorderStyle.None, Color.Gray, 1, ButtonBorderStyle.Solid);
		}


		#endregion UI controls

	}
}
