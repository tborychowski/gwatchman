using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

class Locale {
	private Boolean isLang = false;
	private XmlDocument langDoc;

	// Constructor - loads xml lang file if it exists
	public Locale(String langID) {
		if (langID == null || langID.Length == 0) this.isLang = false;
		else { // try to load the language file
			this.langDoc = new XmlDocument();
			String fileName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\lang\\" + langID + ".xml";
			if (System.IO.File.Exists(fileName)) {
				this.langDoc.Load(fileName);
				this.isLang = true;
			}
			else {	// load english from file if exists
				fileName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\lang\\English.xml";
				if (System.IO.File.Exists(fileName)) {
					this.langDoc.Load(fileName);
					this.isLang = true;
				}
				else this.isLang = false;
			}
		}
	}

	public String getString(String name) {
		String text = "";
		if (this.isLang) {
			XmlElement elem = this.langDoc.GetElementById(name);
			if (elem != null) {
				text = elem.InnerText;
				if (text != null && text.Length > 0) return text;
				else return getDefaultString(name);
			}
			else return getDefaultString(name);
		}
		else return getDefaultString(name);
	}

	private String getDefaultString(String name){
		String text = "";
		switch (name) {

			// MAIN FORM
			case "hide": text = "hide"; break;
			case "hideLinkTip": text = "Minimize to system tray"; break;
			case "readerLabelTip": text = "Check reader now"; break;
			case "readerLogoTip": text = "Open in browser"; break;
			case "mailLabelTip": text = "Check mail now"; break;
			case "mailLogoTip": text = "Open in browser"; break;
			case "oneMessageAlert": text = "You have %n unread message"; break;
			case "manyMessagesAlert": text = "You have %n unread messages"; break;
			case "oneFeedAlert": text = "You have %n unread feed"; break;
			case "manyFeedsAlert": text = "You have %n unread feeds"; break;

			// TRAY MENU
			case "show": text = "Show"; break;
			case "exit": text = "Exit"; break;
			case "update": text = "Update"; break;
			case "settings": text = "Settings"; break;


			// UPDATE DIALOG
			case "updateNotAvailableTitle": text = "No update available"; break;
			case "updateNotAvailableMsg": text = "Your are using the latest version of GWatchman"; break;
			case "updateAvailableTitle": text = "Update available"; break;
			case "updateAvailable": text = "A newer version of GWatchman is available!"; break;
			case "yourVersion": text = "Your version"; break;
			case "latestVersion": text = "Latest version"; break;
			case "downloadLatestQuestion": text = "Would you like to download the latest file?"; break;



			// SETTINGS
			
			// tree
			case "account": text = "Account"; break;
			case "alert": text = "Alert"; break;
			case "general": text = "General"; break;
			case "about": text = "About"; break;

			// account
			case "username": text = "User name"; break;
			case "password": text = "Password"; break;
			case "rememberLogin": text = "Remember my login"; break;
			case "rememberPassword": text = "Remember login and password"; break;
			case "mail": text = "Mail"; break;
			case "reader": text = "Reader"; break;
			case "checkEvery": text = "Check every"; break;
			case "noAutoCheck": text = "No auto-check"; break;

			// alert
			case "action": text = "Action"; break;
			case "nativePopup": text = "Native pop-up"; break;
			case "nativePopupSettings": text = "Native pop-up settings"; break;
			case "position": text = "Position"; break;
			// position
			case "top": text = "Top"; break;
			case "bottom": text = "Bottom"; break;
			case "middle": text = "Middle"; break;
			case "left": text = "Left"; break;
			case "right": text = "Right"; break;
			case "center": text = "Center"; break;
			case "custom": text = "Custom"; break;

			case "background": text = "Background"; break;
			case "backgroundTip": text = "Display a list of images (png,bmp,jpg,gif)\nfrom the 'background' folder"; break;
			case "textColor": text = "Text color"; break;
			case "textColorInf": text = "html color (hex or name)"; break;
			case "textColorTip": text = "html hex color as hex or name, i.e.:\n#fff, white, #000000"; break;
			case "opacity": text = "Opacity"; break;
			case "dismissDelay": text = "Dismiss delay"; break;

			// general
			case "language": text = "Language"; break;
			case "startWithSystem": text = "Start with system"; break;
			case "getLanguages": text = "Get more languages"; break;
			case "updateOnStart": text = "Check for updates on start"; break;

			// about
			case "aboutText": text = "GWatchman is a freeware app created to kill time and to make a few things easier and quicker.\n\nIf you need more details visit the project's website:"; break;

			case "apply": text = "Apply"; break;
			case "close": text = "Close"; break;
			default: text = ""; break;
		}
		return text;
	}

}
