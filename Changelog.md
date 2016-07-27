# Changelog #

### v.1.0.6.7 beta (2011-11-08) ###
  * Added Russian translation
  * It works with hosted domains (google apps) ([issue 22](https://code.google.com/p/gwatchman/issues/detail?id=22))
  * Gmail url for getting unread messages counter updated ([issue 49](https://code.google.com/p/gwatchman/issues/detail?id=49), [issue 50](https://code.google.com/p/gwatchman/issues/detail?id=50))
  * Fixed reader issue with password containing strange characters ([issue 45](https://code.google.com/p/gwatchman/issues/detail?id=45)), thanks to Santy

### v.1.0.6.6 beta (2011-04-08) ###
  * Added translation for Azerbaijani and Italian
  * Changed "Dismiss Delay" option from seconds to miliseconds
  * Application file and settings file renamed from GWatch to GWatchman (if you have settings in old file - "GWatch.xml" latest version will rename it automatically)
  * Removed dependency for growl dll files (if you don't use growl - you can now remove those files)
  * Added 1-file "mini" version to downloads

### v.1.0.6.5 beta (2011-03-28) ###
  * Added translation for Korean and Portuguese
  * Fixed [issue 37](https://code.google.com/p/gwatchman/issues/detail?id=37) when program displayed a .NET error on start-up (thanks to m.sobotka)
  * Fixed a bug when "apply settings" was multiplying "background" list.

### v.1.0.6.0 beta (2010-11-20) ###
  * Added growl click action (click on alert opens default browser with relevant Google App) ([issue 34](https://code.google.com/p/gwatchman/issues/detail?id=34))
  * Added debug option (run application with -debug switch like this: "GWatch.exe -debug" and it will create GWatch.log with connection status events)
  * Added experimental proxy support ([issue 35](https://code.google.com/p/gwatchman/issues/detail?id=35)) (run application with -proxy switch)
  * Added "About" to the tray menu
  * Added translation for Japanese
  * Enhanced and localized position controls in settings
  * Enhanced appearence of some controls (tray menu, settings dialog)
  * Fixed .NET bug when connection was down


### v.1.0.5.2 beta (2010-11-17) ###
  * Fixed some random .NET bugs ([issue 33](https://code.google.com/p/gwatchman/issues/detail?id=33))
  * Fixed checking one thing only (either Gmail or GReader)
  * Fixed bug when no settings file found


### v.1.0.5.1 beta (2010-11-14) ###
  * Added translations for: Chinese, Spanish and German
  * Added tray icon tooltip with unread numbers ([issue 30](https://code.google.com/p/gwatchman/issues/detail?id=30))
  * Fixed .NET bug with huge number of emails/feeds ([issue 31](https://code.google.com/p/gwatchman/issues/detail?id=31))


### v.1.0.5.0 beta (2010-10-10) ###
  * Added localization support ([issue 6](https://code.google.com/p/gwatchman/issues/detail?id=6))
  * Added tray icon animation when checking for unread items
  * Added tray icon star and error overlays ([issue 29](https://code.google.com/p/gwatchman/issues/detail?id=29))
  * Added "Update" option to the tray menu and "Check for updates on start" to general settings ([issue 28](https://code.google.com/p/gwatchman/issues/detail?id=28))
  * Fixed labels alignment on native pop-up (min. width to 140px)
  * Fixed settings reading: each entry is validated separately (that means more backwards compatibility with reading settings) ([issue 27](https://code.google.com/p/gwatchman/issues/detail?id=27))


### v.1.0.4.5 beta (2010-09-26) ###
  * Added option to turn off mail or reader checking
  * Added support for checking all folders/labels for gmail ([issue 25](https://code.google.com/p/gwatchman/issues/detail?id=25))
  * Added option to change background image and text color for native pop-up ([Issue 5](https://code.google.com/p/gwatchman/issues/detail?id=5))
  * Added "dismiss delay" option to native pop-up settings

### v.1.0.4.4 beta1 (2010-09-11) ###
  * Added "-autorun" argument to not show warnings on app startup (app is also added to the system startup with this argument)

### v.1.0.4.3 beta1 (2010-09-09) ###
  * Start with system option enabled
  * Settings file is read from the exe file location instead of using relative path
  * Fixed small bug causing native popup (if native was disabled) to show up when closing settings dialog

### v.1.0.4.2 beta1 (2010-08-31) ###
  * check if growl is running and display error message if not
  * don't save password if "save password" is unset - settings are not re-read each time settings dialog opens and closes

### v.1.0.4.1 alpha (2010-08-14) ###
  * growl register bug removed (when you switch to growl for the first time)
  * tray icon: single click - check all, double click - open settings

### v.1.0.4.0 alpha (2010-08-12) ###
  * first alpha