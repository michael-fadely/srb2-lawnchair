using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IniFile;

namespace Lawnchair.Forms
{
	public partial class MainWindow : Form
	{
		//	Release Blockers:
		//		TODO: Handle custom config paths
		//		TODO: Separate instances of SRB2Config for standard and dedicated servers?

		// TODO: Function for adding strings to the filelist. Duplicate code =/
		// TODO: Document all functions.
		// TODO: Consider adding automatic file list loading functionality.
		// TODO: Async loading.

		#region Private Members

		public static LawnchairSettings Settings;
		public static ProcessStartInfo StartInfo;

		private readonly string configFile = AssemblyInfo.Title + ".ini";
		private readonly SRB2Config srb2Config = new SRB2Config();

		// TODO: Move
		public static string WorkingDirectory = Environment.CurrentDirectory;
		private string _lastFileList;
		private List<string> filters;
		private readonly List<Process> processList = new List<Process>();

		#endregion

		#region Accessors

		/// <summary>
		/// Wrapper for _lastFileList. Automatically enables or disables File -> Save
		/// </summary>
		private string LastFileList
		{
			get => _lastFileList;
			set
			{
				saveFileListToolStripMenuItem.Enabled = (value != null);
				_lastFileList = value;
			}
		}

		#endregion

		public MainWindow()
		{
			InitializeComponent();

			comboHostGametype.SelectedIndex = 0;
			comboWarpGametype.SelectedIndex = 0;
			//comboGameVersion.SelectedIndex = 0;
		}

		private void MainWindow_Load(object sender, EventArgs e)
		{
			Text = AssemblyInfo.Title;
			MinimumSize = Size;

			LoadLauncherIni();
			ApplyLauncherSettings();

			UpdateFilterList();
		}

		void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			SaveSettings();
		}

		private void LoadLauncherIni()
		{
			if (File.Exists(configFile))
			{
				Settings = IniSerializer.Deserialize<LawnchairSettings>(configFile);
			}
			else
			{
				Settings = new LawnchairSettings();
				StoreLauncherSettings();
			}

			DoGameVersionThings();
			SetWorkingDirectory(Settings.Game.Executable);
		}

		private void ApplyLauncherSettings()
		{
			// Launcher Config - Handled by settings dialog

			// Join
			textJoinIPAddress.Text  = Settings.Join.Address;
			textJoinPortNum.Text    = Settings.Join.ClientPort.ToString();
			checkNoDownload.Checked = Settings.Join.NoDownload;
			checkNoFiles.Checked    = Settings.Join.NoFiles;

			// Host
			comboHostGametype.SelectedIndex = Settings.Host.Gametype;
			textHostMapNum.Text             = Settings.Host.Map;

			radioHostStandardRoom.Checked = Settings.Host.StandardRoom;
			radioHostCasualRoom.Checked   = !radioHostStandardRoom.Checked;

			checkHostOnline.Checked       = Settings.Host.ShowOnline;
			checkHostFileDownload.Checked = Settings.Host.FileDownload;
			checkHostDedicated.Checked    = Settings.Host.Dedicated;
			textHostPass.Text             = Settings.Host.AdminPassword;

			// Video
			checkWindowedMode.Checked     = Settings.Game.WindowedMode;
			checkCustomResolution.Checked = Settings.Game.CustomResolution;
			textScreenWidth.Text          = Settings.Game.ScreenWidth.ToString();
			textScreenHeight.Text         = Settings.Game.ScreenHeight.ToString();

			radioRendSoftware.Checked = Settings.Game.SoftwareRenderer;
			radioRendOpenGL.Checked   = !radioRendSoftware.Checked;

			// Misc
			checkShowConsole.Checked = Settings.Game.ShowConsole;
			textExecutable.Text      = Settings.Game.Executable;

			if (!string.IsNullOrEmpty(Settings.Game.CommandLine))
				textCommandLine.Text = Settings.Game.CommandLine;

			// Audio
			checkEnableSFX.Checked = Settings.Game.EnableSFX;
			checkEnableBGM.Checked = Settings.Game.EnableBGM;
			checkMusicDIGI.Checked = Settings.Game.MusicDIGI;
			checkMusicMIDI.Checked = Settings.Game.MusicMIDI;

			// Warp
			checkEnableWarp.Checked         = Settings.Game.Warp;
			textWarpMapNum.Text             = Settings.Game.Map;
			comboWarpGametype.SelectedIndex = Settings.Game.Gametype;

			// Filters
			DragDropFilter.IsFilterEnabled = Settings.Filters.Enabled;
		}

		private void SaveSettings()
		{
			StoreLauncherSettings();
			SaveLauncherIni();
			SaveGameConfig();
		}

		private void StoreLauncherSettings()
		{
			// Launcher Config - Handled by settings dialog
			//settings.Launcher.MinimizeOnLaunch = toolStripMinimizeOnLaunch.Checked;

			// Join
			Settings.Join.Address    = textJoinIPAddress.Text;
			Settings.Join.ClientPort = Convert.ToInt32(textJoinPortNum.Text);
			Settings.Join.NoDownload = checkNoDownload.Checked;
			Settings.Join.NoFiles    = checkNoFiles.Checked;

			// Host
			Settings.Host.Gametype = comboHostGametype.SelectedIndex;
			Settings.Host.Map      = textHostMapNum.Text;

			Settings.Host.StandardRoom = radioHostStandardRoom.Checked;

			Settings.Host.ShowOnline    = checkHostOnline.Checked;
			Settings.Host.FileDownload  = checkHostFileDownload.Checked;
			Settings.Host.Dedicated     = checkHostDedicated.Checked;
			Settings.Host.AdminPassword = textHostPass.Text;

			// Video
			Settings.Game.WindowedMode     = checkWindowedMode.Checked;
			Settings.Game.CustomResolution = checkCustomResolution.Checked;
			Settings.Game.ScreenWidth      = Convert.ToInt32(textScreenWidth.Text);
			Settings.Game.ScreenHeight     = Convert.ToInt32(textScreenHeight.Text);

			Settings.Game.SoftwareRenderer = radioRendSoftware.Checked;

			// Misc
			Settings.Game.ShowConsole = checkShowConsole.Checked;
			Settings.Game.Executable  = textExecutable.Text;
			Settings.Game.CommandLine = textCommandLine.Text;

			// Audio
			Settings.Game.EnableSFX = checkEnableSFX.Checked;
			Settings.Game.EnableBGM = checkEnableBGM.Checked;
			Settings.Game.MusicDIGI = checkMusicDIGI.Checked;
			Settings.Game.MusicMIDI = checkMusicMIDI.Checked;

			// Warp
			Settings.Game.Warp     = checkEnableWarp.Checked;
			Settings.Game.Map      = textWarpMapNum.Text;
			Settings.Game.Gametype = comboWarpGametype.SelectedIndex;
		}

		private void SaveLauncherIni()
		{
			IniSerializer.Serialize(Settings, configFile);
		}

		private void LoadGameConfig()
		{
			string path = Path.Combine(WorkingDirectory, (checkHostNetgame.Checked && checkHostDedicated.Checked) ? "dconfig.cfg" : "config.cfg");

			if (!File.Exists(path))
			{
				return;
			}

			srb2Config.Load(path);

			string serverName = srb2Config.GetFirst("servername");

			if (!string.IsNullOrEmpty(serverName))
			{
				textServerName.Text = serverName;
			}

			if (int.TryParse(srb2Config.GetFirst("maxplayers"), out int maxPlayers))
			{
				numericMaxPlayers.Value = maxPlayers;
			}
		}

		private void SaveGameConfig()
		{
			if (!srb2Config.Loaded)
			{
				return;
			}

			string serverName = srb2Config.GetFirst("servername");

			if (serverName != textServerName.Text)
			{
				srb2Config.Set("servername", textServerName.Text);
			}

			string maxPlayers = srb2Config.GetFirst("maxplayers");
			string strMaxPlayers = numericMaxPlayers.Value.ToString(CultureInfo.InvariantCulture);

			if (string.IsNullOrEmpty(maxPlayers) || maxPlayers != strMaxPlayers)
			{
				srb2Config.Set("maxplayers", strMaxPlayers);
			}

			srb2Config.SaveChanged();
		}

		/// <summary>
		/// Disables the map warp option if any netgame options are enabled.
		/// </summary>
		private void DisableWarp()
		{
			if (!checkJoinNetgame.Checked && !checkHostNetgame.Checked)
			{
				return;
			}

			checkEnableWarp.Checked = (!checkJoinNetgame.Checked && !checkHostNetgame.Checked);
		}

		private DialogResult CheckFileList()
		{
			if (listFiles.Items.Count <= 0)
			{
				return DialogResult.No;
			}

			return MessageBox.Show("There are already files in the file list. Would you like to clear the list before loading?"
			                       + "\nSelecting \"No\" will merge with the current list.", "Warning!",
			                       MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
		}

		private void LoadFileListIni(bool overwrite, string path)
		{
			listFiles.BeginUpdate();

			if (overwrite)
			{
				listFiles.Items.Clear();
			}

			LastFileList = null;

			if (path.Length > 0)
			{
				List<string> files = IniSerializer.Deserialize<List<string>>(path);
				try
				{
					foreach (string s in files)
					{
						listFiles.Items.Add(s);
					}

					if (openFileListDialog.FileNames.Count() == 1)
					{
						LastFileList = openFileListDialog.FileName;
					}
				}
				catch (Exception error)
				{
					MessageBox.Show("An error has occurred while trying to load the file " + path + "\n\n" + error.Message,
					                "Error while loading file list INI", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}

			listFiles.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
			listFiles.Select();

			listFiles.EndUpdate();
		}

		private void SaveFileListIni(string path)
		{
			if (listFiles.Items.Count < 1)
			{
				MessageBox.Show("Your file list is empty; you cannot save an empty file list!", "Unable to save file list",
				                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

				return;
			}

			if (string.IsNullOrEmpty(path))
				return;

			List<string> files = (from ListViewItem i in listFiles.Items select i.Text).ToList();

			try
			{
				IniSerializer.Serialize(files, path);
				LastFileList = path;
			}
			catch (Exception error)
			{
				MessageBox.Show("An error has occurred while trying to save the file " + path + "\n\n" + error.Message,
				                "Error while saving file list INI", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void SetWorkingDirectory(string path)
		{
			string filePath = Helper.StripDirectory(path, Environment.CurrentDirectory);
			string fileName = Path.GetFileName(filePath);

			if (string.IsNullOrEmpty(filePath) || string.IsNullOrEmpty(fileName))
			{
				MessageBox.Show("Unable to deduce filename from custom executable path.", "Invalid path", MessageBoxButtons.OK, MessageBoxIcon.Error);
				textExecutable.Select();
				return;
			}

			string fileDir = Path.GetDirectoryName(filePath) ?? string.Empty;

			if (StartInfo == null)
			{
				StartInfo = new ProcessStartInfo
				{
					FileName         = fileName,
					WorkingDirectory = fileDir
				};
			}
			else
			{
				StartInfo.FileName = fileName;
				StartInfo.WorkingDirectory = fileDir;
			}

			WorkingDirectory = string.IsNullOrEmpty(fileDir) ? Environment.CurrentDirectory : fileDir;

			LoadGameConfig();
		}

		private void UpdateFilterList()
		{
			filters = new List<string>();

			if (Settings.Filters.AllowWAD)
			{
				filters.Add(".wad");
			}

			if (Settings.Filters.AllowSOC)
			{
				filters.Add(".soc");
			}

			if (Settings.Filters.AllowLua)
			{
				filters.Add(".lua");
			}

			if (Settings.Filters.AllowSRB)
			{
				filters.Add(".srb");
			}

			if (Settings.Filters.AllowDTA)
			{
				filters.Add(".dta");
			}

			if (Settings.Filters.AllowPLR)
			{
				filters.Add(".plr");
			}

			if (Settings.Filters.AllowWPN)
			{
				filters.Add(".wpn");
			}

			foreach (KeyValuePair<string, bool> d in Settings.Filters.CustomFilters.Where(d => d.Value))
			{
				filters.Add(d.Key.ToLower());
			}
		}

		private void LaunchGame()
		{
			if (checkJoinNetgame.Checked && listFiles.Items.Count > 0)
			{
				if (MessageBox.Show("You have files in the file list but you are trying to join a netgame."
				                    + "\nCustom files are ignored when connecting to a server at startup."
				                    +
				                    "\n\nIf you are using a music wad, you will have to add it ingame from the title screen. Press OK to continue.",
				                    "Warning",
				                    MessageBoxButtons.OKCancel,
				                    MessageBoxIcon.Warning) == DialogResult.Cancel)
				{
					return;
				}
			}

			SaveSettings();
			List<string> args = new List<string>();

			if (!(checkHostDedicated.Checked && checkHostNetgame.Checked))
			{
				// Check if Windowed Mode is checked
				if (checkWindowedMode.Checked)
				{
					args.Add("-win");
				}

				// Check if a custom resolution is used
				if (checkCustomResolution.Checked)
				{
					args.Add("-width");
					args.Add(textScreenWidth.Text);
					args.Add("-height");
					args.Add(textScreenHeight.Text);
				}

				// Check render mode
				// This portion specifically is for SRB2CB support.
				if (radioRendSoftware.Checked && textExecutable.Text == "srb2cb.exe")
				{
					args.Add("-software");
				}

				if (radioRendOpenGL.Checked)
				{
					args.Add("-opengl");
				}

				// Check if music is enabled
				if (checkEnableBGM.Checked)
				{
					// And if it is, check what types are enabled
					if (!checkMusicDIGI.Checked)
					{
						args.Add("-nodigmusic");
					}

					if (!checkMusicMIDI.Checked)
					{
						args.Add("-nomidimusic");
					}
				}
				else
				{
					args.Add("-nomusic");
				}

				// Check if sound is enabled
				if (!checkEnableSFX.Checked)
				{
					args.Add("-nosound");
				}

				if (checkShowConsole.Checked)
				{
					args.Add("-console");
				}
			}

			// Check netgame options
			if (checkJoinNetgame.Checked)
			{
				args.Add("-connect");
				args.Add(textJoinIPAddress.Text);

				if (textJoinPortNum.Text != "5029" && textJoinPortNum.TextLength > 0)
				{
					args.Add("-clientport");
					args.Add(textJoinPortNum.Text);
				}

				if (checkNoDownload.Checked)
				{
					args.Add(checkNoFiles.Checked ? "-nofiles" : "-nodownload");
				}
			}
			else if (checkHostNetgame.Checked)
			{
				args.Add("-server");

				if (checkHostOnline.Checked && Settings.Launcher.GameVersion < SRB2Version.v21x)
				{
					args.Add("-internetserver");
				}

				if (Settings.Launcher.GameVersion >= SRB2Version.v20x)
				{
					if (radioHostStandardRoom.Checked && Settings.Launcher.GameVersion < SRB2Version.v21x ||
					    radioHostStandardRoom.Checked && Settings.Launcher.GameVersion == SRB2Version.v21x && checkHostOnline.Checked)
					{
						args.Add("-room 33");
					}
					else if (radioHostCasualRoom.Checked && Settings.Launcher.GameVersion < SRB2Version.v21x ||
					         radioHostCasualRoom.Checked && Settings.Launcher.GameVersion == SRB2Version.v21x && checkHostOnline.Checked)
					{
						args.Add("-room 28");
					}
				}

				if (!checkHostFileDownload.Checked)
				{
					args.Add(item: "-nodownloading");
				}

				if (textHostPass.Text.Length > 0)
				{
					args.Add(item: "-password");
				}

				if (checkHostDedicated.Checked)
				{
					args.Add(item: "-dedicated");
				}

				if (Helper.CheckMapNum(textHostMapNum.Text))
				{
					tabControlMain.SelectTab(tabPageNetplay);
					tabNetplay.SelectTab(tabPageNetHost);
					textHostMapNum.Select();
					return;
				}

				if (textHostMapNum.TextLength < 3)
				{
					args.Add(Helper.WarpHandler(Helper.ExMapToInt(textHostMapNum.Text).ToString(),
					                            comboHostGametype.SelectedItem.ToString(), Settings.Launcher.GameVersion));
				}
				else
				{
					args.Add(Helper.WarpHandler(textHostMapNum.Text, comboHostGametype.SelectedItem.ToString(), Settings.Launcher.GameVersion));
				}
			}
			else if (!checkJoinNetgame.Checked && !checkHostNetgame.Checked && checkEnableWarp.Checked)
			{
				if (Helper.CheckMapNum(textWarpMapNum.Text))
				{
					tabControlMain.SelectTab(tabPageOptions);
					textWarpMapNum.Select();
					return;
				}

				if (textWarpMapNum.TextLength < 3)
				{
					args.Add(Helper.WarpHandler(Helper.ExMapToInt(textWarpMapNum.Text).ToString(),
					                            comboWarpGametype.SelectedItem.ToString(), Settings.Launcher.GameVersion));
				}
				else
				{
					args.Add(Helper.WarpHandler(textWarpMapNum.Text, comboWarpGametype.SelectedItem.ToString(), Settings.Launcher.GameVersion));
				}
			}

			// Now for files!

			if (listFiles.Items.Count > 0)
			{
				args.Add("-file");
				args.AddRange(from ListViewItem i in listFiles.Items select "\"" + i.Text + "\"");
			}

			// Custom Command-line arguments
			if (!string.IsNullOrEmpty(textCommandLine.Text))
			{
				args.Add(textCommandLine.Text);
			}

			// Finally, launch the game with the generated args
			try
			{
				StartInfo.Arguments = string.Empty;
				StartInfo.Arguments = string.Join(" ", args);

				Process process = new Process { StartInfo = StartInfo, EnableRaisingEvents = true };
				process.Exited += gameProcess_Exited;
				processList.Add(process);

				process.Start();

				if (Settings.Launcher.MinimizeOnLaunch)
				{
					Minimize();
				}
			}
			catch (Exception runException)
			{
				MessageBox.Show("An error occurred while trying to launch the game.\n" + runException.Message,
				                "Unable to launch SRB2", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Minimize()
		{
			WindowState = FormWindowState.Minimized;
		}

		private void Restore()
		{
			WindowState = FormWindowState.Normal;
		}

		#region Event Handlers

		private void gameProcess_Exited(object sender, EventArgs e)
		{
			processList.Remove((Process)sender);
			Invoke((Action)LoadGameConfig);

			if (Settings.Launcher.MinimizeOnLaunch && processList.Count == 0)
			{
				Invoke((Action)Restore);
			}
		}

		private void onCheck_checkCustomResolution(object sender, EventArgs e)
		{
			textScreenWidth.Enabled = checkCustomResolution.Checked;
			textScreenHeight.Enabled = checkCustomResolution.Checked;
		}

		private void onCheck_checkJoinNetgame(object sender, EventArgs e)
		{
			groupJoinBasic.Enabled = checkJoinNetgame.Checked;
			groupJoinAdvanced.Enabled = checkJoinNetgame.Checked;
		}

		private void onCheck_checkHostNetgame(object sender, EventArgs e)
		{
			groupHostBasic.Enabled = checkHostNetgame.Checked;
			groupHostAdv.Enabled = checkHostNetgame.Checked;
		}

		private void onStateChange_checkJoinNetgame(object sender, EventArgs e)
		{
			if (checkJoinNetgame.Checked)
			{
				checkHostNetgame.Checked = false;
			}

			DisableWarp();
		}

		private void onStateChange_checkHostNetgame(object sender, EventArgs e)
		{
			if (checkHostNetgame.Checked)
			{
				checkJoinNetgame.Checked = false;
			}

			DisableWarp();
		}

		private void onCheck_checkEnableWarp(object sender, EventArgs e)
		{
			textWarpMapNum.Enabled = checkEnableWarp.Checked;
			comboWarpGametype.Enabled = checkEnableWarp.Checked;

			if (checkEnableWarp.Checked)
			{
				checkJoinNetgame.Checked = false;
				checkHostNetgame.Checked = false;
			}
		}

		private void onCheck_checkEnableBGM(object sender, EventArgs e)
		{
			groupMusicType.Enabled = checkEnableBGM.Checked;
		}

		private void onClick_buttonFileAdd(object sender, EventArgs e)
		{
			listFiles.BeginUpdate();

			if (addFileDialog.ShowDialog() == DialogResult.OK && addFileDialog.FileNames.Length > 0)
			{
				foreach (string i in addFileDialog.FileNames)
				{
					listFiles.Items.Add(Helper.StripDirectory(i, WorkingDirectory), 0);
				}

				listFiles.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
			}

			listFiles.Select();
			listFiles.EndUpdate();
		}

		private void onClick_buttonFileRemove(object sender, EventArgs e)
		{
			listFiles.BeginUpdate();

			if (listFiles.SelectedIndices.Count == listFiles.Items.Count)
			{
				listFiles.Items.Clear();
			}
			else
			{
				foreach (ListViewItem i in listFiles.SelectedItems)
				{
					listFiles.Items.Remove(i);
				}
			}

			listFiles.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
			listFiles.Select();
			listFiles.EndUpdate();
		}

		private void onClick_buttonFileUp(object sender, EventArgs e)
		{
			if (listFiles.SelectedItems.Count < 1)
			{
				return;
			}

			listFiles.BeginUpdate();

			for (int i = 0; i < listFiles.SelectedItems.Count; i++)
			{
				int index = listFiles.SelectedItems[i].Index;

				if (index-- <= 0 || listFiles.Items[index].Selected)
				{
					continue;
				}

				ListViewItem item = listFiles.SelectedItems[i];
				listFiles.Items.Remove(item);
				listFiles.Items.Insert(index, item);
			}

			listFiles.SelectedItems[0].EnsureVisible();
			listFiles.Select();
			listFiles.EndUpdate();
		}

		private void onClick_buttonFileDown(object sender, EventArgs e)
		{
			if (listFiles.SelectedItems.Count < 1)
			{
				return;
			}

			listFiles.BeginUpdate();

			for (int i = listFiles.SelectedItems.Count - 1; i >= 0; i--)
			{
				int index = listFiles.SelectedItems[i].Index;

				if (++index == listFiles.Items.Count || listFiles.Items[index].Selected)
				{
					continue;
				}

				ListViewItem item = listFiles.SelectedItems[i];
				listFiles.Items.Remove(item);
				listFiles.Items.Insert(index, item);
			}

			listFiles.SelectedItems[listFiles.SelectedItems.Count - 1].EnsureVisible();
			listFiles.Select();
			listFiles.EndUpdate();
		}

		private void onTextChanged_textWarpMapNum(object sender, EventArgs e)
		{
			StringBuilder sb = new StringBuilder(textWarpMapNum.Text.Length);
			int lastpos = textWarpMapNum.SelectionStart;

			foreach (char c in textWarpMapNum.Text)
			{
				if ((c >= 'a' & c <= 'z') || (c >= 'A' & c <= 'Z') || (c >= '0' & c <= '9'))
				{
					sb.Append(c);
				}
				else
				{
					lastpos--;
				}
			}

			textWarpMapNum.Text = sb.ToString();
			textWarpMapNum.SelectionStart = (lastpos <= textWarpMapNum.TextLength) ? lastpos : textWarpMapNum.TextLength;
		}

		private void winWidth_TextChanged(object sender, EventArgs e)
		{
			StringBuilder sb = new StringBuilder(textScreenWidth.Text.Length);
			int lastpos = textScreenWidth.SelectionStart;

			foreach (char c in textScreenWidth.Text)
			{
				if (c >= '0' & c <= '9')
				{
					sb.Append(c);
				}
				else
				{
					lastpos--;
				}
			}

			textScreenWidth.Text = sb.ToString();
			textScreenWidth.SelectionStart = (lastpos <= textScreenWidth.TextLength) ? lastpos : textScreenWidth.TextLength;
		}

		private void onTextChanged_textScreenHeight(object sender, EventArgs e)
		{
			StringBuilder sb = new StringBuilder(textScreenHeight.Text.Length);
			int lastpos = textScreenHeight.SelectionStart;

			foreach (char c in textScreenHeight.Text)
			{
				if (c >= '0' & c <= '9')
				{
					sb.Append(c);
				}
				else
				{
					lastpos--;
				}
			}

			textScreenHeight.Text = sb.ToString();
			textScreenHeight.SelectionStart = (lastpos <= textScreenHeight.TextLength) ? lastpos : textScreenHeight.TextLength;
		}

		private void onTextChanged_textPortNum(object sender, EventArgs e)
		{
			StringBuilder sb = new StringBuilder(textJoinPortNum.Text.Length);
			int lastpos = textJoinPortNum.SelectionStart;

			foreach (char c in textJoinPortNum.Text)
			{
				if (c >= '0' & c <= '9')
				{
					sb.Append(c);
				}
				else
				{
					lastpos--;
				}
			}

			textJoinPortNum.Text = sb.ToString();
			textJoinPortNum.SelectionStart = (lastpos <= textJoinPortNum.TextLength) ? lastpos : textJoinPortNum.TextLength;
		}

		private void onTextChanged_textHostMapNum(object sender, EventArgs e)
		{
			StringBuilder sb = new StringBuilder(textHostMapNum.Text.Length);
			int lastpos = textHostMapNum.SelectionStart;

			foreach (char c in textHostMapNum.Text)
			{
				if ((c >= 'a' & c <= 'z') || (c >= 'A' & c <= 'Z') || (c >= '0' & c <= '9'))
				{
					sb.Append(c);
				}
				else
				{
					lastpos--;
				}
			}

			textHostMapNum.Text = sb.ToString();
			textHostMapNum.SelectionStart = (lastpos <= textHostMapNum.TextLength) ? lastpos : textHostMapNum.TextLength;
		}

		private void buttonExeBrowse_Click(object sender, EventArgs e)
		{
			if (openExeDialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}

			SetWorkingDirectory(openExeDialog.FileName);
			textExecutable.Text = Path.Combine(StartInfo.WorkingDirectory, StartInfo.FileName);
		}

		private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			using (AboutWindow about = new AboutWindow())
			{
				about.ShowDialog();
			}
		}

		private void openFileListToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult result = CheckFileList();

			bool overwrite = (result == DialogResult.Yes);

			if (openFileListDialog.ShowDialog() != DialogResult.OK || openFileListDialog.FileNames.Length <= 0)
			{
				return;
			}

			foreach (string ini in openFileListDialog.FileNames)
			{
				LoadFileListIni(overwrite, ini);
			}
		}

		private void saveFileListToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileListIni(LastFileList);
		}

		private void saveFileListAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (saveFileListDialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}

			SaveFileListIni(saveFileListDialog.FileName);
		}

		private void clearFileListToolStripMenuItem_Click(object sender, EventArgs e)
		{
			listFiles.BeginUpdate();
			listFiles.Items.Clear();

			LastFileList = null;

			listFiles.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
			//listFileList.Select();
			listFiles.EndUpdate();
		}

		private void textOptCmd_Click(object sender, EventArgs e)
		{
			if (textCommandLine.Text == "Custom Command-line Arguments")
			{
				textCommandLine.Text = "";
			}
		}

		private void listFileList_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.All : DragDropEffects.None;
		}

		private void listFileList_DragDrop(object sender, DragEventArgs e)
		{
			// First, check if the data dropped is the kind we want
			if (!e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				return;
			}

			listFiles.BeginUpdate();

			string[] droppedStrings = (string[])e.Data.GetData(DataFormats.FileDrop, false);

			foreach (string s in droppedStrings)
			{
				// For every string, check if it is a file or a directory,
				// and whether or not it exists.
				if (File.Exists(s))
				{
					FileInfo file = new FileInfo(s);

					if (file.Extension.ToLower() == ".ini")
					{
						DialogResult result = CheckFileList();

						bool overwrite;

						switch (result)
						{
							case DialogResult.Yes:
								overwrite = true;
								break;
							case DialogResult.No:
								overwrite = false;
								break;
							default:
								return;
						}

						LoadFileListIni(overwrite, file.FullName);
					}
					else if (Helper.IsCommonFile(file.Extension, ref filters))
					{
						listFiles.Items.Add(Helper.StripDirectory(s, WorkingDirectory));
					}
				}
				else if (Directory.Exists(s))
				{
					DirectoryInfo dir = new DirectoryInfo(s);

					foreach (string f in Helper.FileStrings(dir, ref filters))
					{
						listFiles.Items.Add(Helper.StripDirectory(f, WorkingDirectory));
					}
				}
			}

			// Re-size the column based on the new content
			listFiles.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
			// Select the list and end the update
			listFiles.Select();
			listFiles.EndUpdate();
		}

		private void dragDropFilterToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult result;

			using (DragDropFilter dialog = new DragDropFilter(Settings))
			{
				result = dialog.ShowDialog();
			}

			if (result == DialogResult.OK)
			{
				UpdateFilterList();
			}
		}

		private void listFileList_SelectedIndexChanged(object sender, EventArgs e)
		{
			int selectionCount = listFiles.SelectedItems.Count;
			int selectedIndex  = 0;

			if (selectionCount > 0)
			{
				selectedIndex = listFiles.SelectedIndices[0];
			}

			switch (selectionCount)
			{
				case 0:
					buttonFileUp.Enabled = false;
					buttonFileDown.Enabled = false;
					break;

				case 1:
					buttonFileUp.Enabled = (selectedIndex > 0);
					buttonFileDown.Enabled = (selectedIndex < listFiles.Items.Count - 1);
					break;

				default:
					if (selectionCount > 1)
					{
						buttonFileUp.Enabled = true;
						buttonFileDown.Enabled = true;
					}

					break;
			}
		}

		private void openSRB2FolderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SetWorkingDirectory(textExecutable.Text);
			Process.Start(WorkingDirectory);
		}

		private void MusicTypeCheck(object sender, EventArgs e)
		{
			if (checkMusicDIGI.Checked || checkMusicMIDI.Checked)
			{
				return;
			}

			checkMusicDIGI.Checked = true;
			checkMusicMIDI.Checked = true;
			checkEnableBGM.Checked = false;
		}

		private void checkNoDownload_CheckedChanged(object sender, EventArgs e)
		{
			checkNoFiles.Enabled = checkNoDownload.Checked;
		}

		private void checkHostOnline_CheckedChanged(object sender, EventArgs e)
		{
			if (Settings.Launcher.GameVersion != SRB2Version.v21x)
			{
				return;
			}

			radioHostStandardRoom.Enabled = checkHostOnline.Checked;
			radioHostCasualRoom.Enabled = checkHostOnline.Checked;
		}

		private void DoGameVersionThings()
		{
			switch (Settings.Launcher.GameVersion)
			{
				case SRB2Version.v21x:
					radioHostStandardRoom.Enabled = checkHostOnline.Checked;
					radioHostCasualRoom.Enabled = checkHostOnline.Checked;

					Helper.GametypeHandler(ref comboWarpGametype, Settings.Launcher.GameVersion);
					Helper.GametypeHandler(ref comboHostGametype, Settings.Launcher.GameVersion);
					break;

				case SRB2Version.v20x:
					if (!radioHostStandardRoom.Enabled)
					{
						radioHostStandardRoom.Enabled = true;
						radioHostCasualRoom.Enabled = true;
					}

					Helper.GametypeHandler(ref comboWarpGametype, Settings.Launcher.GameVersion);
					Helper.GametypeHandler(ref comboHostGametype, Settings.Launcher.GameVersion);
					break;

				case SRB2Version.v109x:
					radioHostStandardRoom.Enabled = false;
					radioHostCasualRoom.Enabled = false;

					Helper.GametypeHandler(ref comboWarpGametype, Settings.Launcher.GameVersion);
					Helper.GametypeHandler(ref comboHostGametype, Settings.Launcher.GameVersion);
					break;

				case SRB2Version.v108x:
					break;

				default:
					throw new ArgumentOutOfRangeException();
			}
		}

		private void TextGainFocus(object sender, EventArgs e)
		{
			Helper.TextAutoSelectText((TextBox)sender);
		}

		private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (Settings winSettings = new Settings(Settings))
			{
				if (winSettings.ShowDialog() == DialogResult.OK)
				{
					// TODO: !!! config paths !!!
					DoGameVersionThings();
				}
			}
		}

		private void buttonLaunch_Click(object sender, EventArgs e)
		{
			LaunchGame();
		}

		private void checkHostDedicated_CheckedChanged(object sender, EventArgs e)
		{
			LoadGameConfig();
		}

		private void textExeName_Leave(object sender, EventArgs e)
		{
			SetWorkingDirectory(((TextBox)sender).Text);
		}

		private void buttonCommandLineHelp_Click(object sender, EventArgs e)
		{
			Process.Start("https://wiki.srb2.org/wiki/Command_line_parameters");
		}

		#endregion
	}
}