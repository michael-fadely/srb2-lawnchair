using System.Collections.Generic;
using System.ComponentModel;
using IniFile;

namespace Lawnchair
{
	public class LawnchairSettings
	{
		[IniAlwaysInclude]
		[IniName("Launcher Options")]
		public readonly LauncherSettings Launcher = new LauncherSettings();

		[IniAlwaysInclude]
		[IniName("Game Arguments")]
		public readonly GameArguments Game = new GameArguments();

		[IniAlwaysInclude]
		[IniName("Join Arguments")]
		public readonly NetplayJoin Join = new NetplayJoin();

		[IniAlwaysInclude]
		[IniName("Host Arguments")]
		public readonly NetplayHost Host = new NetplayHost();

		[IniAlwaysInclude]
		[IniName("Drag Drop Filters")]
		public readonly FilterSettings Filters = new FilterSettings();
	}

	public class LauncherSettings
	{
		[IniAlwaysInclude]
		public SRB2Version GameVersion;

		[IniAlwaysInclude]
		[DefaultValue(true)]
		public bool MinimizeOnLaunch;
	}

	public class GameArguments
	{
		[DefaultValue("config.cfg")]
		public string ConfigPath;

		[DefaultValue("dconfig.cfg")]
		public string DConfigPath;

		[IniAlwaysInclude]
		public bool WindowedMode;

		[IniAlwaysInclude]
		public bool CustomResolution;

		[IniAlwaysInclude]
		[DefaultValue(640)]
		public int ScreenWidth;

		[IniAlwaysInclude]
		[DefaultValue(400)]
		public int ScreenHeight;

		[IniAlwaysInclude]
		[DefaultValue(true)]
		public bool SoftwareRenderer;

		[IniAlwaysInclude]
		[DefaultValue(true)]
		public bool EnableSFX;

		[IniAlwaysInclude]
		[DefaultValue(true)]
		public bool EnableBGM;

		[IniAlwaysInclude]
		[DefaultValue(true)]
		public bool MusicDIGI;

		[IniAlwaysInclude]
		[DefaultValue(true)]
		public bool MusicMIDI;

		[IniAlwaysInclude]
		public bool ShowConsole;

		[DefaultValue("srb2win.exe")]
		public string Executable;

		[DefaultValue("")]
		public string CommandLine;

		[IniAlwaysInclude]
		public bool Warp;

		[IniAlwaysInclude]
		[DefaultValue("01")]
		public string Map;

		[DefaultValue(-1)]
		public int Gametype;
	}

	public class NetplayJoin
	{
		[IniAlwaysInclude]
		[DefaultValue("localhost")]
		public string Address;

		[IniAlwaysInclude]
		[DefaultValue(5029)]
		public int ClientPort;

		[IniAlwaysInclude]
		[DefaultValue(false)]
		public bool NoDownload;

		[IniAlwaysInclude]
		[DefaultValue(false)]
		public bool NoFiles;
	}

	public class NetplayHost
	{
		[IniAlwaysInclude]
		[DefaultValue("01")]
		public string Map;

		[DefaultValue(-1)]
		public int Gametype;

		[IniAlwaysInclude]
		[DefaultValue(true)]
		public bool StandardRoom;

		[IniAlwaysInclude]
		[DefaultValue(true)]
		public bool ShowOnline;

		[IniAlwaysInclude]
		[DefaultValue(true)]
		public bool FileDownload;

		[IniAlwaysInclude]
		public bool Dedicated;

		[DefaultValue("")]
		public string AdminPassword;
	}

	public class FilterSettings
	{
		public FilterSettings()
		{
			Enabled  = true;
			AllowPK3 = true;
			AllowWAD = true;
			AllowSOC = true;
			AllowLua = true;

			CustomFilters = new Dictionary<string, bool>();
		}

		[IniAlwaysInclude]
		public bool Enabled;

		public bool AllowPK3;
		public bool AllowWAD;
		public bool AllowSOC;
		public bool AllowLua;
		public bool AllowSRB;
		public bool AllowDTA;
		public bool AllowPLR;
		public bool AllowWPN;

		[IniCollection(IniCollectionMode.IndexOnly)]
		public Dictionary<string, bool> CustomFilters;
	}
}
