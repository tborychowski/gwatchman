using System;
using Microsoft.Win32;
using System.Reflection;

/// <summary>
/// Enables or disables the autostart (with the OS) of the application.
/// </summary>
public static class AutoStart {
	private const string RUN_LOCATION = @"Software\Microsoft\Windows\CurrentVersion\Run";
	private const string AppName = "GWatchman";
	private const string switches = " -autorun";		// don't show growl warning on startup

	/// <summary>
	/// Set the autostart value for the assembly.
	/// </summary>
	public static void SetAutoStart() {
		RegistryKey key = Registry.CurrentUser.CreateSubKey(RUN_LOCATION);
		key.SetValue(AppName, "\"" + Assembly.GetExecutingAssembly().Location + "\"" + switches);
	}

	/// <summary>
	/// Returns whether auto start is enabled.
	/// </summary>
	public static bool IsAutoStartEnabled {
		get {
			RegistryKey key = Registry.CurrentUser.OpenSubKey(RUN_LOCATION);
			if (key == null) return false;
			string value = (string)key.GetValue(AppName);
			if (value == null) return false;
			return (value == "\"" + Assembly.GetExecutingAssembly().Location + "\"" + switches);
		}
	}

	/// <summary>
	/// Unsets the autostart value for the assembly.
	/// </summary>
	public static void UnSetAutoStart() {
		RegistryKey key = Registry.CurrentUser.CreateSubKey(RUN_LOCATION);
		key.DeleteValue(AppName);
	}
}