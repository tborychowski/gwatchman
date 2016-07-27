# Localization #

Since version 1.0.5.0 GWatchman supports localization.
Application starts in English by default and you can change the language in Settings>General.

The dropdown will show you the list of language files located in "lang" folder in the application directory (e.g. English.xml)
Default - English is available even if there is no English language file.

A language file is simple xml file with language strings.


## How to translate ##
You can translate GWatchman to your language yourself.
To do that just do a copy of English.xml and rename it to your language name (e.g. Polish.xml).
Than edit the file in any text editor you like.

In the xml file you'll see something like that:
```
<item id="hideLinkTip">Minimize to system tray</item>
```
Translate the text between "_item_" tags. (do not translate the "_id_"!), e.g.:
```
<item id="hideLinkTip">Zminimalizuj do zasobnika</item>
```

If you want to contribute - send me your translation (tborychowski@gmail) and I will put it here next to your nickname.


## Available Languages ##
Right-click -> Save as:
| Language file | Translated by | Version | Last update |
|:--------------|:--------------|:--------|:------------|
| [Azerbaijani](http://gwatchman.googlecode.com/svn/languages/Azerbaijani.xml) | Ilkin | 1.0 | 07/04/2011 |
| [Chinese](http://gwatchman.googlecode.com/svn/languages/Chinese.xml) | [Tevin](mailto:tian.exe@gmail.com) | 1.1 | 11/10/2010 |
| [Dutch](http://gwatchman.googlecode.com/svn/languages/Dutch.xml) | Harold | 1.0 | 03/04/2012 |
| [English](http://gwatchman.googlecode.com/svn/languages/English.xml) | [me](mailto:herhor@o2.pl) | 1.1 |  01/11/2010 |
| [French](http://gwatchman.googlecode.com/svn/languages/French.xml) | Yoann | 1.0 | 25/02/2012 |
| [German](http://gwatchman.googlecode.com/svn/languages/German.xml) | Aga | 1.0 | 11/11/2010 |
| [Italian](http://gwatchman.googlecode.com/svn/languages/Italian.xml) | Drugo | 1.0 | 05/04/2011 |
| [Japanese](http://gwatchman.googlecode.com/svn/languages/Japanese.xml) | [LANG](mailto:lang@hlang.com) | 1.0 | 20/11/2010 |
| [Korean](http://gwatchman.googlecode.com/svn/languages/Korean.xml) | [Kevin](mailto:sea4hans@gmail.com) | 1.0 | 27/11/2010 |
| [Polish](http://gwatchman.googlecode.com/svn/languages/Polish.xml) | [me](mailto:herhor@o2.pl) | 1.1 | 01/11/2010 |
| [Portuguese](http://gwatchman.googlecode.com/svn/languages/Portuguese.xml) | Trambulhao | 1.1 | 05/04/2011 |
| [Russian](http://gwatchman.googlecode.com/svn/languages/Russian.xml) | Pohran | 1.0 | 30/05/2011 |
| [Spanish](http://gwatchman.googlecode.com/svn/languages/Spanish.xml) | [ToMMZ](mailto:eme3studio@gmail.com) | 1.0 | 04/11/2010 |
| [Turkish](http://gwatchman.googlecode.com/svn/languages/Turkish.xml) | Pyloge | 1.0 | 10/12/2011 |