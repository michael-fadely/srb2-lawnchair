using System.ComponentModel;
using System.Windows.Forms;

namespace Lawnchair.Forms
{
	partial class MainWindow
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.tabControlMain = new System.Windows.Forms.TabControl();
			this.tabPageFiles = new System.Windows.Forms.TabPage();
			this.buttonFileRemove = new System.Windows.Forms.Button();
			this.buttonFileDown = new System.Windows.Forms.Button();
			this.buttonFileAdd = new System.Windows.Forms.Button();
			this.buttonFileUp = new System.Windows.Forms.Button();
			this.listFiles = new System.Windows.Forms.ListView();
			this.columnFiles = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tabPageNetplay = new System.Windows.Forms.TabPage();
			this.tabNetplay = new System.Windows.Forms.TabControl();
			this.tabPageNetJoin = new System.Windows.Forms.TabPage();
			this.checkJoinNetgame = new System.Windows.Forms.CheckBox();
			this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
			this.groupJoinBasic = new System.Windows.Forms.GroupBox();
			this.textJoinPortNum = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textJoinIPAddress = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.groupJoinAdvanced = new System.Windows.Forms.GroupBox();
			this.checkNoDownload = new System.Windows.Forms.CheckBox();
			this.checkNoFiles = new System.Windows.Forms.CheckBox();
			this.tabPageNetHost = new System.Windows.Forms.TabPage();
			this.checkHostNetgame = new System.Windows.Forms.CheckBox();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.groupHostBasic = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.radioHostCasualRoom = new System.Windows.Forms.RadioButton();
			this.numericMaxPlayers = new System.Windows.Forms.NumericUpDown();
			this.radioHostStandardRoom = new System.Windows.Forms.RadioButton();
			this.textServerName = new System.Windows.Forms.TextBox();
			this.checkHostOnline = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textHostMapNum = new System.Windows.Forms.TextBox();
			this.comboHostGametype = new System.Windows.Forms.ComboBox();
			this.groupHostAdv = new System.Windows.Forms.GroupBox();
			this.checkHostFileDownload = new System.Windows.Forms.CheckBox();
			this.textHostPass = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.checkHostDedicated = new System.Windows.Forms.CheckBox();
			this.tabPageOptions = new System.Windows.Forms.TabPage();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.groupOptRes = new System.Windows.Forms.GroupBox();
			this.textScreenHeight = new System.Windows.Forms.TextBox();
			this.checkCustomResolution = new System.Windows.Forms.CheckBox();
			this.textScreenWidth = new System.Windows.Forms.TextBox();
			this.checkWindowedMode = new System.Windows.Forms.CheckBox();
			this.labelOptRes = new System.Windows.Forms.Label();
			this.groupOptRend = new System.Windows.Forms.GroupBox();
			this.radioRendOpenGL = new System.Windows.Forms.RadioButton();
			this.radioRendSoftware = new System.Windows.Forms.RadioButton();
			this.groupOptExe = new System.Windows.Forms.GroupBox();
			this.buttonCommandLineHelp = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.textCommandLine = new System.Windows.Forms.TextBox();
			this.buttonExeBrowse = new System.Windows.Forms.Button();
			this.checkShowConsole = new System.Windows.Forms.CheckBox();
			this.labelOptExe = new System.Windows.Forms.Label();
			this.textExecutable = new System.Windows.Forms.TextBox();
			this.groupOptSound = new System.Windows.Forms.GroupBox();
			this.groupMusicType = new System.Windows.Forms.GroupBox();
			this.checkMusicMIDI = new System.Windows.Forms.CheckBox();
			this.checkMusicDIGI = new System.Windows.Forms.CheckBox();
			this.checkEnableBGM = new System.Windows.Forms.CheckBox();
			this.checkEnableSFX = new System.Windows.Forms.CheckBox();
			this.groupWarp = new System.Windows.Forms.GroupBox();
			this.checkEnableWarp = new System.Windows.Forms.CheckBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.textWarpMapNum = new System.Windows.Forms.TextBox();
			this.comboWarpGametype = new System.Windows.Forms.ComboBox();
			this.buttonLaunch = new System.Windows.Forms.Button();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.addFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.openExeDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveFileListDialog = new System.Windows.Forms.SaveFileDialog();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clearFileListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openFileListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveFileListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveFileListAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.openSRB2FolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSettings = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripDragDropFilter = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openFileListDialog = new System.Windows.Forms.OpenFileDialog();
			this.tabControlMain.SuspendLayout();
			this.tabPageFiles.SuspendLayout();
			this.tabPageNetplay.SuspendLayout();
			this.tabNetplay.SuspendLayout();
			this.tabPageNetJoin.SuspendLayout();
			this.flowLayoutPanel3.SuspendLayout();
			this.groupJoinBasic.SuspendLayout();
			this.groupJoinAdvanced.SuspendLayout();
			this.tabPageNetHost.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			this.groupHostBasic.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericMaxPlayers)).BeginInit();
			this.groupHostAdv.SuspendLayout();
			this.tabPageOptions.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.groupOptRes.SuspendLayout();
			this.groupOptRend.SuspendLayout();
			this.groupOptExe.SuspendLayout();
			this.groupOptSound.SuspendLayout();
			this.groupMusicType.SuspendLayout();
			this.groupWarp.SuspendLayout();
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControlMain
			// 
			this.tabControlMain.AllowDrop = true;
			this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControlMain.Controls.Add(this.tabPageFiles);
			this.tabControlMain.Controls.Add(this.tabPageNetplay);
			this.tabControlMain.Controls.Add(this.tabPageOptions);
			this.tabControlMain.Location = new System.Drawing.Point(12, 28);
			this.tabControlMain.Name = "tabControlMain";
			this.tabControlMain.SelectedIndex = 0;
			this.tabControlMain.Size = new System.Drawing.Size(344, 343);
			this.tabControlMain.TabIndex = 1;
			// 
			// tabPageFiles
			// 
			this.tabPageFiles.AllowDrop = true;
			this.tabPageFiles.Controls.Add(this.buttonFileRemove);
			this.tabPageFiles.Controls.Add(this.buttonFileDown);
			this.tabPageFiles.Controls.Add(this.buttonFileAdd);
			this.tabPageFiles.Controls.Add(this.buttonFileUp);
			this.tabPageFiles.Controls.Add(this.listFiles);
			this.tabPageFiles.Location = new System.Drawing.Point(4, 22);
			this.tabPageFiles.Name = "tabPageFiles";
			this.tabPageFiles.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageFiles.Size = new System.Drawing.Size(336, 317);
			this.tabPageFiles.TabIndex = 0;
			this.tabPageFiles.Text = "Files";
			this.tabPageFiles.UseVisualStyleBackColor = true;
			// 
			// buttonFileRemove
			// 
			this.buttonFileRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonFileRemove.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonFileRemove.Location = new System.Drawing.Point(255, 280);
			this.buttonFileRemove.Name = "buttonFileRemove";
			this.buttonFileRemove.Size = new System.Drawing.Size(75, 23);
			this.buttonFileRemove.TabIndex = 4;
			this.buttonFileRemove.Text = "&Remove";
			this.toolTip.SetToolTip(this.buttonFileRemove, "Remove selected file(s) from the file list.");
			this.buttonFileRemove.UseVisualStyleBackColor = true;
			this.buttonFileRemove.Click += new System.EventHandler(this.onClick_buttonFileRemove);
			// 
			// buttonFileDown
			// 
			this.buttonFileDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonFileDown.Enabled = false;
			this.buttonFileDown.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonFileDown.Location = new System.Drawing.Point(38, 280);
			this.buttonFileDown.Name = "buttonFileDown";
			this.buttonFileDown.Size = new System.Drawing.Size(26, 23);
			this.buttonFileDown.TabIndex = 2;
			this.buttonFileDown.Text = "↓";
			this.toolTip.SetToolTip(this.buttonFileDown, "Move selected file(s) down.");
			this.buttonFileDown.UseVisualStyleBackColor = true;
			this.buttonFileDown.Click += new System.EventHandler(this.onClick_buttonFileDown);
			// 
			// buttonFileAdd
			// 
			this.buttonFileAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonFileAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonFileAdd.Location = new System.Drawing.Point(174, 280);
			this.buttonFileAdd.Name = "buttonFileAdd";
			this.buttonFileAdd.Size = new System.Drawing.Size(75, 23);
			this.buttonFileAdd.TabIndex = 3;
			this.buttonFileAdd.Text = "&Add";
			this.toolTip.SetToolTip(this.buttonFileAdd, "Add custom files to the list to use in SRB2.");
			this.buttonFileAdd.UseVisualStyleBackColor = true;
			this.buttonFileAdd.Click += new System.EventHandler(this.onClick_buttonFileAdd);
			// 
			// buttonFileUp
			// 
			this.buttonFileUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonFileUp.Enabled = false;
			this.buttonFileUp.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonFileUp.Location = new System.Drawing.Point(6, 280);
			this.buttonFileUp.Name = "buttonFileUp";
			this.buttonFileUp.Size = new System.Drawing.Size(26, 23);
			this.buttonFileUp.TabIndex = 1;
			this.buttonFileUp.Text = "↑";
			this.toolTip.SetToolTip(this.buttonFileUp, "Move selected file(s) up.");
			this.buttonFileUp.UseVisualStyleBackColor = true;
			this.buttonFileUp.Click += new System.EventHandler(this.onClick_buttonFileUp);
			// 
			// listFiles
			// 
			this.listFiles.AllowColumnReorder = true;
			this.listFiles.AllowDrop = true;
			this.listFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnFiles});
			this.listFiles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.listFiles.HideSelection = false;
			this.listFiles.Location = new System.Drawing.Point(6, 6);
			this.listFiles.Name = "listFiles";
			this.listFiles.ShowItemToolTips = true;
			this.listFiles.Size = new System.Drawing.Size(324, 268);
			this.listFiles.TabIndex = 0;
			this.listFiles.UseCompatibleStateImageBehavior = false;
			this.listFiles.View = System.Windows.Forms.View.Details;
			this.listFiles.SelectedIndexChanged += new System.EventHandler(this.listFileList_SelectedIndexChanged);
			this.listFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.listFileList_DragDrop);
			this.listFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.listFileList_DragEnter);
			// 
			// columnFiles
			// 
			this.columnFiles.Text = "Filenames";
			this.columnFiles.Width = 25;
			// 
			// tabPageNetplay
			// 
			this.tabPageNetplay.Controls.Add(this.tabNetplay);
			this.tabPageNetplay.Location = new System.Drawing.Point(4, 22);
			this.tabPageNetplay.Name = "tabPageNetplay";
			this.tabPageNetplay.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageNetplay.Size = new System.Drawing.Size(336, 317);
			this.tabPageNetplay.TabIndex = 1;
			this.tabPageNetplay.Text = "Netplay";
			this.tabPageNetplay.UseVisualStyleBackColor = true;
			// 
			// tabNetplay
			// 
			this.tabNetplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabNetplay.Controls.Add(this.tabPageNetJoin);
			this.tabNetplay.Controls.Add(this.tabPageNetHost);
			this.tabNetplay.Location = new System.Drawing.Point(3, 3);
			this.tabNetplay.Name = "tabNetplay";
			this.tabNetplay.SelectedIndex = 0;
			this.tabNetplay.Size = new System.Drawing.Size(330, 311);
			this.tabNetplay.TabIndex = 0;
			// 
			// tabPageNetJoin
			// 
			this.tabPageNetJoin.BackColor = System.Drawing.Color.WhiteSmoke;
			this.tabPageNetJoin.Controls.Add(this.checkJoinNetgame);
			this.tabPageNetJoin.Controls.Add(this.flowLayoutPanel3);
			this.tabPageNetJoin.Location = new System.Drawing.Point(4, 22);
			this.tabPageNetJoin.Name = "tabPageNetJoin";
			this.tabPageNetJoin.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageNetJoin.Size = new System.Drawing.Size(322, 285);
			this.tabPageNetJoin.TabIndex = 0;
			this.tabPageNetJoin.Text = "Join";
			// 
			// checkJoinNetgame
			// 
			this.checkJoinNetgame.AutoSize = true;
			this.checkJoinNetgame.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkJoinNetgame.Location = new System.Drawing.Point(6, 6);
			this.checkJoinNetgame.Name = "checkJoinNetgame";
			this.checkJoinNetgame.Size = new System.Drawing.Size(97, 18);
			this.checkJoinNetgame.TabIndex = 0;
			this.checkJoinNetgame.Text = "Join Netgame";
			this.toolTip.SetToolTip(this.checkJoinNetgame, "Connects to a netgame (server) at the IP address specified below.\r\nIf enabled, \"H" +
        "ost Netgame\" is disabled automatically.");
			this.checkJoinNetgame.UseVisualStyleBackColor = true;
			this.checkJoinNetgame.CheckedChanged += new System.EventHandler(this.onCheck_checkJoinNetgame);
			this.checkJoinNetgame.CheckStateChanged += new System.EventHandler(this.onStateChange_checkJoinNetgame);
			// 
			// flowLayoutPanel3
			// 
			this.flowLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.flowLayoutPanel3.Controls.Add(this.groupJoinBasic);
			this.flowLayoutPanel3.Controls.Add(this.groupJoinAdvanced);
			this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 30);
			this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel3.Name = "flowLayoutPanel3";
			this.flowLayoutPanel3.Size = new System.Drawing.Size(322, 255);
			this.flowLayoutPanel3.TabIndex = 3;
			// 
			// groupJoinBasic
			// 
			this.groupJoinBasic.Controls.Add(this.textJoinPortNum);
			this.groupJoinBasic.Controls.Add(this.label7);
			this.groupJoinBasic.Controls.Add(this.textJoinIPAddress);
			this.groupJoinBasic.Controls.Add(this.label9);
			this.groupJoinBasic.Enabled = false;
			this.groupJoinBasic.Location = new System.Drawing.Point(3, 3);
			this.groupJoinBasic.Name = "groupJoinBasic";
			this.groupJoinBasic.Size = new System.Drawing.Size(178, 71);
			this.groupJoinBasic.TabIndex = 1;
			this.groupJoinBasic.TabStop = false;
			this.groupJoinBasic.Text = "Basic";
			// 
			// textJoinPortNum
			// 
			this.textJoinPortNum.Location = new System.Drawing.Point(73, 45);
			this.textJoinPortNum.MaxLength = 5;
			this.textJoinPortNum.Name = "textJoinPortNum";
			this.textJoinPortNum.Size = new System.Drawing.Size(48, 20);
			this.textJoinPortNum.TabIndex = 1;
			this.textJoinPortNum.Text = "5029";
			this.toolTip.SetToolTip(this.textJoinPortNum, "Defines the port to connect with. If unsure, leave unchanged.\r\nYou should only ne" +
        "ed this if you\'re connecting to your own\r\ndedicated server. If so, change it to " +
        "5030.");
			this.textJoinPortNum.TextChanged += new System.EventHandler(this.onTextChanged_textPortNum);
			this.textJoinPortNum.Enter += new System.EventHandler(this.TextGainFocus);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(38, 48);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(29, 13);
			this.label7.TabIndex = 13;
			this.label7.Text = "Port:";
			this.toolTip.SetToolTip(this.label7, "Defines the port to connect with. If unsure, leave unchanged.\r\nYou should only ne" +
        "ed this if you\'re connecting to your own\r\ndedicated server. If so, change it to " +
        "5030.");
			// 
			// textJoinIPAddress
			// 
			this.textJoinIPAddress.Location = new System.Drawing.Point(73, 19);
			this.textJoinIPAddress.Name = "textJoinIPAddress";
			this.textJoinIPAddress.Size = new System.Drawing.Size(99, 20);
			this.textJoinIPAddress.TabIndex = 0;
			this.textJoinIPAddress.Text = "127.0.0.1";
			this.toolTip.SetToolTip(this.textJoinIPAddress, "Defines the IP address to connect to.");
			this.textJoinIPAddress.Enter += new System.EventHandler(this.TextGainFocus);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(6, 22);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(61, 13);
			this.label9.TabIndex = 0;
			this.label9.Text = "IP Address:";
			// 
			// groupJoinAdvanced
			// 
			this.groupJoinAdvanced.Controls.Add(this.checkNoDownload);
			this.groupJoinAdvanced.Controls.Add(this.checkNoFiles);
			this.groupJoinAdvanced.Enabled = false;
			this.groupJoinAdvanced.Location = new System.Drawing.Point(187, 3);
			this.groupJoinAdvanced.Name = "groupJoinAdvanced";
			this.groupJoinAdvanced.Size = new System.Drawing.Size(126, 71);
			this.groupJoinAdvanced.TabIndex = 2;
			this.groupJoinAdvanced.TabStop = false;
			this.groupJoinAdvanced.Text = "Advanced";
			// 
			// checkNoDownload
			// 
			this.checkNoDownload.AutoSize = true;
			this.checkNoDownload.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkNoDownload.Location = new System.Drawing.Point(6, 19);
			this.checkNoDownload.Name = "checkNoDownload";
			this.checkNoDownload.Size = new System.Drawing.Size(125, 18);
			this.checkNoDownload.TabIndex = 0;
			this.checkNoDownload.Text = "No file downloading";
			this.toolTip.SetToolTip(this.checkNoDownload, "Disables downloading custom files (WADs and SOCs) from the server.");
			this.checkNoDownload.UseVisualStyleBackColor = true;
			this.checkNoDownload.CheckedChanged += new System.EventHandler(this.checkNoDownload_CheckedChanged);
			// 
			// checkNoFiles
			// 
			this.checkNoFiles.AutoSize = true;
			this.checkNoFiles.Enabled = false;
			this.checkNoFiles.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkNoFiles.Location = new System.Drawing.Point(18, 42);
			this.checkNoFiles.Name = "checkNoFiles";
			this.checkNoFiles.Size = new System.Drawing.Size(104, 18);
			this.checkNoFiles.TabIndex = 1;
			this.checkNoFiles.Text = "Quit on attempt";
			this.toolTip.SetToolTip(this.checkNoFiles, "Quits when being forced to download files.\r\n");
			this.checkNoFiles.UseVisualStyleBackColor = true;
			// 
			// tabPageNetHost
			// 
			this.tabPageNetHost.BackColor = System.Drawing.Color.WhiteSmoke;
			this.tabPageNetHost.Controls.Add(this.checkHostNetgame);
			this.tabPageNetHost.Controls.Add(this.flowLayoutPanel2);
			this.tabPageNetHost.Location = new System.Drawing.Point(4, 22);
			this.tabPageNetHost.Name = "tabPageNetHost";
			this.tabPageNetHost.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageNetHost.Size = new System.Drawing.Size(322, 285);
			this.tabPageNetHost.TabIndex = 1;
			this.tabPageNetHost.Text = "Host";
			// 
			// checkHostNetgame
			// 
			this.checkHostNetgame.AutoSize = true;
			this.checkHostNetgame.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkHostNetgame.Location = new System.Drawing.Point(6, 6);
			this.checkHostNetgame.Name = "checkHostNetgame";
			this.checkHostNetgame.Size = new System.Drawing.Size(100, 18);
			this.checkHostNetgame.TabIndex = 0;
			this.checkHostNetgame.Text = "Host Netgame";
			this.toolTip.SetToolTip(this.checkHostNetgame, "Hosts a netgame (server) with the options below.\r\nIf enabled, \"Join Netgame\" is a" +
        "utomatically disabled.");
			this.checkHostNetgame.UseVisualStyleBackColor = true;
			this.checkHostNetgame.CheckedChanged += new System.EventHandler(this.onCheck_checkHostNetgame);
			this.checkHostNetgame.CheckStateChanged += new System.EventHandler(this.onStateChange_checkHostNetgame);
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.flowLayoutPanel2.Controls.Add(this.groupHostBasic);
			this.flowLayoutPanel2.Controls.Add(this.groupHostAdv);
			this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 30);
			this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(322, 255);
			this.flowLayoutPanel2.TabIndex = 3;
			// 
			// groupHostBasic
			// 
			this.groupHostBasic.Controls.Add(this.label6);
			this.groupHostBasic.Controls.Add(this.label8);
			this.groupHostBasic.Controls.Add(this.label4);
			this.groupHostBasic.Controls.Add(this.radioHostCasualRoom);
			this.groupHostBasic.Controls.Add(this.numericMaxPlayers);
			this.groupHostBasic.Controls.Add(this.radioHostStandardRoom);
			this.groupHostBasic.Controls.Add(this.textServerName);
			this.groupHostBasic.Controls.Add(this.checkHostOnline);
			this.groupHostBasic.Controls.Add(this.label3);
			this.groupHostBasic.Controls.Add(this.label5);
			this.groupHostBasic.Controls.Add(this.textHostMapNum);
			this.groupHostBasic.Controls.Add(this.comboHostGametype);
			this.groupHostBasic.Enabled = false;
			this.groupHostBasic.Location = new System.Drawing.Point(3, 3);
			this.groupHostBasic.Name = "groupHostBasic";
			this.groupHostBasic.Size = new System.Drawing.Size(310, 175);
			this.groupHostBasic.TabIndex = 1;
			this.groupHostBasic.TabStop = false;
			this.groupHostBasic.Text = "Basic";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 22);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(72, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "Server Name:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(40, 126);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(38, 13);
			this.label8.TabIndex = 8;
			this.label8.Text = "Room:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 47);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "Max players:";
			// 
			// radioHostCasualRoom
			// 
			this.radioHostCasualRoom.AutoSize = true;
			this.radioHostCasualRoom.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.radioHostCasualRoom.Location = new System.Drawing.Point(164, 148);
			this.radioHostCasualRoom.Name = "radioHostCasualRoom";
			this.radioHostCasualRoom.Size = new System.Drawing.Size(63, 18);
			this.radioHostCasualRoom.TabIndex = 11;
			this.radioHostCasualRoom.TabStop = true;
			this.radioHostCasualRoom.Text = "Casual";
			this.toolTip.SetToolTip(this.radioHostCasualRoom, "Hosts the server in the Casual room.\r\nUse this for role-playing and hangout.");
			this.radioHostCasualRoom.UseVisualStyleBackColor = true;
			// 
			// numericMaxPlayers
			// 
			this.numericMaxPlayers.Location = new System.Drawing.Point(84, 45);
			this.numericMaxPlayers.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
			this.numericMaxPlayers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericMaxPlayers.Name = "numericMaxPlayers";
			this.numericMaxPlayers.Size = new System.Drawing.Size(42, 20);
			this.numericMaxPlayers.TabIndex = 3;
			this.numericMaxPlayers.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
			// 
			// radioHostStandardRoom
			// 
			this.radioHostStandardRoom.AutoSize = true;
			this.radioHostStandardRoom.Checked = true;
			this.radioHostStandardRoom.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.radioHostStandardRoom.Location = new System.Drawing.Point(84, 148);
			this.radioHostStandardRoom.Name = "radioHostStandardRoom";
			this.radioHostStandardRoom.Size = new System.Drawing.Size(74, 18);
			this.radioHostStandardRoom.TabIndex = 10;
			this.radioHostStandardRoom.TabStop = true;
			this.radioHostStandardRoom.Text = "Standard";
			this.toolTip.SetToolTip(this.radioHostStandardRoom, "Hosts the server in the Standard room.\r\nUse this for standard play in appropriate" +
        " maps.");
			this.radioHostStandardRoom.UseVisualStyleBackColor = true;
			// 
			// textServerName
			// 
			this.textServerName.Location = new System.Drawing.Point(84, 19);
			this.textServerName.Name = "textServerName";
			this.textServerName.Size = new System.Drawing.Size(128, 20);
			this.textServerName.TabIndex = 1;
			this.textServerName.Text = "SRB2 Server";
			this.toolTip.SetToolTip(this.textServerName, "Defines the name for the server.\r\nLeave blank and it will be the last used server" +
        " name.");
			// 
			// checkHostOnline
			// 
			this.checkHostOnline.AutoSize = true;
			this.checkHostOnline.Checked = true;
			this.checkHostOnline.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkHostOnline.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkHostOnline.Location = new System.Drawing.Point(84, 124);
			this.checkHostOnline.Name = "checkHostOnline";
			this.checkHostOnline.Size = new System.Drawing.Size(92, 18);
			this.checkHostOnline.TabIndex = 9;
			this.checkHostOnline.Text = "Show Online";
			this.toolTip.SetToolTip(this.checkHostOnline, "Shows the server on the Master Server.\r\n(Anyone can join)");
			this.checkHostOnline.UseVisualStyleBackColor = true;
			this.checkHostOnline.CheckedChanged += new System.EventHandler(this.checkHostOnline_CheckedChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 74);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Map number:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(20, 100);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(58, 13);
			this.label5.TabIndex = 6;
			this.label5.Text = "Gametype:";
			// 
			// textHostMapNum
			// 
			this.textHostMapNum.Location = new System.Drawing.Point(84, 71);
			this.textHostMapNum.MaxLength = 4;
			this.textHostMapNum.Name = "textHostMapNum";
			this.textHostMapNum.Size = new System.Drawing.Size(42, 20);
			this.textHostMapNum.TabIndex = 5;
			this.textHostMapNum.Text = "01";
			this.toolTip.SetToolTip(this.textHostMapNum, "Specifies which map to warp to on startup.\r\n");
			this.textHostMapNum.Click += new System.EventHandler(this.TextGainFocus);
			this.textHostMapNum.TextChanged += new System.EventHandler(this.onTextChanged_textHostMapNum);
			this.textHostMapNum.Enter += new System.EventHandler(this.TextGainFocus);
			// 
			// comboHostGametype
			// 
			this.comboHostGametype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboHostGametype.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.comboHostGametype.FormattingEnabled = true;
			this.comboHostGametype.Items.AddRange(new object[] {
            "derp"});
			this.comboHostGametype.Location = new System.Drawing.Point(84, 97);
			this.comboHostGametype.Name = "comboHostGametype";
			this.comboHostGametype.Size = new System.Drawing.Size(128, 21);
			this.comboHostGametype.TabIndex = 7;
			// 
			// groupHostAdv
			// 
			this.groupHostAdv.Controls.Add(this.checkHostFileDownload);
			this.groupHostAdv.Controls.Add(this.textHostPass);
			this.groupHostAdv.Controls.Add(this.label1);
			this.groupHostAdv.Controls.Add(this.checkHostDedicated);
			this.groupHostAdv.Enabled = false;
			this.groupHostAdv.Location = new System.Drawing.Point(3, 184);
			this.groupHostAdv.Name = "groupHostAdv";
			this.groupHostAdv.Size = new System.Drawing.Size(310, 67);
			this.groupHostAdv.TabIndex = 2;
			this.groupHostAdv.TabStop = false;
			this.groupHostAdv.Text = "Advanced";
			// 
			// checkHostFileDownload
			// 
			this.checkHostFileDownload.AutoSize = true;
			this.checkHostFileDownload.Checked = true;
			this.checkHostFileDownload.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkHostFileDownload.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkHostFileDownload.Location = new System.Drawing.Point(6, 19);
			this.checkHostFileDownload.Name = "checkHostFileDownload";
			this.checkHostFileDownload.Size = new System.Drawing.Size(144, 18);
			this.checkHostFileDownload.TabIndex = 0;
			this.checkHostFileDownload.Text = "Enable file downloading";
			this.toolTip.SetToolTip(this.checkHostFileDownload, "Allows players to download files from the server.\r\nMaximum filesize must be confi" +
        "gured ingame.");
			this.checkHostFileDownload.UseVisualStyleBackColor = true;
			// 
			// textHostPass
			// 
			this.textHostPass.Location = new System.Drawing.Point(100, 41);
			this.textHostPass.MaxLength = 8;
			this.textHostPass.Name = "textHostPass";
			this.textHostPass.PasswordChar = '•';
			this.textHostPass.Size = new System.Drawing.Size(100, 20);
			this.textHostPass.TabIndex = 3;
			this.toolTip.SetToolTip(this.textHostPass, "Defines an administrator password. Useful for dedicated servers.\r\nLogging in with" +
        " it grants you administrator.\r\nMaximum length is 8 characters. Leave blank and n" +
        "o pass will be set.");
			this.textHostPass.Enter += new System.EventHandler(this.TextGainFocus);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Admin Password:";
			this.toolTip.SetToolTip(this.label1, "Defines an administrator password. Useful for dedicated servers.\r\nLogging in with" +
        " it grants you administrator.\r\nMaximum length is 8 characters. Leave blank and n" +
        "o pass will be set.");
			// 
			// checkHostDedicated
			// 
			this.checkHostDedicated.AutoSize = true;
			this.checkHostDedicated.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkHostDedicated.Location = new System.Drawing.Point(156, 19);
			this.checkHostDedicated.Name = "checkHostDedicated";
			this.checkHostDedicated.Size = new System.Drawing.Size(81, 18);
			this.checkHostDedicated.TabIndex = 1;
			this.checkHostDedicated.Text = "Dedicated";
			this.toolTip.SetToolTip(this.checkHostDedicated, "Hosts the server as a dedicated server (command prompt).");
			this.checkHostDedicated.UseVisualStyleBackColor = true;
			this.checkHostDedicated.CheckedChanged += new System.EventHandler(this.checkHostDedicated_CheckedChanged);
			// 
			// tabPageOptions
			// 
			this.tabPageOptions.Controls.Add(this.flowLayoutPanel1);
			this.tabPageOptions.Location = new System.Drawing.Point(4, 22);
			this.tabPageOptions.Name = "tabPageOptions";
			this.tabPageOptions.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageOptions.Size = new System.Drawing.Size(336, 317);
			this.tabPageOptions.TabIndex = 2;
			this.tabPageOptions.Text = "Options";
			this.tabPageOptions.UseVisualStyleBackColor = true;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.groupOptRes);
			this.flowLayoutPanel1.Controls.Add(this.groupOptRend);
			this.flowLayoutPanel1.Controls.Add(this.groupOptExe);
			this.flowLayoutPanel1.Controls.Add(this.groupOptSound);
			this.flowLayoutPanel1.Controls.Add(this.groupWarp);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(330, 311);
			this.flowLayoutPanel1.TabIndex = 5;
			// 
			// groupOptRes
			// 
			this.groupOptRes.Controls.Add(this.textScreenHeight);
			this.groupOptRes.Controls.Add(this.checkCustomResolution);
			this.groupOptRes.Controls.Add(this.textScreenWidth);
			this.groupOptRes.Controls.Add(this.checkWindowedMode);
			this.groupOptRes.Controls.Add(this.labelOptRes);
			this.groupOptRes.Location = new System.Drawing.Point(3, 3);
			this.groupOptRes.Name = "groupOptRes";
			this.groupOptRes.Size = new System.Drawing.Size(208, 64);
			this.groupOptRes.TabIndex = 0;
			this.groupOptRes.TabStop = false;
			this.groupOptRes.Text = "Resolution options";
			// 
			// textScreenHeight
			// 
			this.textScreenHeight.Enabled = false;
			this.textScreenHeight.Location = new System.Drawing.Point(170, 38);
			this.textScreenHeight.Name = "textScreenHeight";
			this.textScreenHeight.Size = new System.Drawing.Size(32, 20);
			this.textScreenHeight.TabIndex = 3;
			this.textScreenHeight.Text = "400";
			this.toolTip.SetToolTip(this.textScreenHeight, "Defines the screen height.");
			this.textScreenHeight.Click += new System.EventHandler(this.TextGainFocus);
			this.textScreenHeight.TextChanged += new System.EventHandler(this.onTextChanged_textScreenHeight);
			this.textScreenHeight.Enter += new System.EventHandler(this.TextGainFocus);
			// 
			// checkCustomResolution
			// 
			this.checkCustomResolution.AutoSize = true;
			this.checkCustomResolution.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkCustomResolution.Location = new System.Drawing.Point(6, 40);
			this.checkCustomResolution.Name = "checkCustomResolution";
			this.checkCustomResolution.Size = new System.Drawing.Size(115, 18);
			this.checkCustomResolution.TabIndex = 1;
			this.checkCustomResolution.Text = "Custom resolution";
			this.toolTip.SetToolTip(this.checkCustomResolution, "Change the game\'s resolution or window size.");
			this.checkCustomResolution.UseVisualStyleBackColor = true;
			this.checkCustomResolution.CheckedChanged += new System.EventHandler(this.onCheck_checkCustomResolution);
			// 
			// textScreenWidth
			// 
			this.textScreenWidth.Enabled = false;
			this.textScreenWidth.Location = new System.Drawing.Point(121, 38);
			this.textScreenWidth.Name = "textScreenWidth";
			this.textScreenWidth.Size = new System.Drawing.Size(32, 20);
			this.textScreenWidth.TabIndex = 2;
			this.textScreenWidth.Text = "640";
			this.toolTip.SetToolTip(this.textScreenWidth, "Defines the screen width.");
			this.textScreenWidth.Click += new System.EventHandler(this.TextGainFocus);
			this.textScreenWidth.TextChanged += new System.EventHandler(this.winWidth_TextChanged);
			this.textScreenWidth.Enter += new System.EventHandler(this.TextGainFocus);
			// 
			// checkWindowedMode
			// 
			this.checkWindowedMode.AutoSize = true;
			this.checkWindowedMode.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkWindowedMode.Location = new System.Drawing.Point(6, 18);
			this.checkWindowedMode.Name = "checkWindowedMode";
			this.checkWindowedMode.Size = new System.Drawing.Size(112, 18);
			this.checkWindowedMode.TabIndex = 0;
			this.checkWindowedMode.Text = "Windowed mode";
			this.toolTip.SetToolTip(this.checkWindowedMode, "Play the game in a window instead of fullscreen.");
			this.checkWindowedMode.UseVisualStyleBackColor = true;
			// 
			// labelOptRes
			// 
			this.labelOptRes.AutoSize = true;
			this.labelOptRes.Location = new System.Drawing.Point(156, 40);
			this.labelOptRes.Name = "labelOptRes";
			this.labelOptRes.Size = new System.Drawing.Size(12, 13);
			this.labelOptRes.TabIndex = 2;
			this.labelOptRes.Text = "x";
			// 
			// groupOptRend
			// 
			this.groupOptRend.Controls.Add(this.radioRendOpenGL);
			this.groupOptRend.Controls.Add(this.radioRendSoftware);
			this.groupOptRend.Location = new System.Drawing.Point(217, 3);
			this.groupOptRend.Name = "groupOptRend";
			this.groupOptRend.Size = new System.Drawing.Size(110, 64);
			this.groupOptRend.TabIndex = 1;
			this.groupOptRend.TabStop = false;
			this.groupOptRend.Text = "Renderer settings";
			// 
			// radioRendOpenGL
			// 
			this.radioRendOpenGL.AutoSize = true;
			this.radioRendOpenGL.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.radioRendOpenGL.Location = new System.Drawing.Point(6, 41);
			this.radioRendOpenGL.Name = "radioRendOpenGL";
			this.radioRendOpenGL.Size = new System.Drawing.Size(71, 18);
			this.radioRendOpenGL.TabIndex = 1;
			this.radioRendOpenGL.Text = "OpenGL";
			this.radioRendOpenGL.UseVisualStyleBackColor = true;
			// 
			// radioRendSoftware
			// 
			this.radioRendSoftware.AutoSize = true;
			this.radioRendSoftware.Checked = true;
			this.radioRendSoftware.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.radioRendSoftware.Location = new System.Drawing.Point(6, 18);
			this.radioRendSoftware.Name = "radioRendSoftware";
			this.radioRendSoftware.Size = new System.Drawing.Size(73, 18);
			this.radioRendSoftware.TabIndex = 0;
			this.radioRendSoftware.TabStop = true;
			this.radioRendSoftware.Text = "Software";
			this.radioRendSoftware.UseVisualStyleBackColor = true;
			// 
			// groupOptExe
			// 
			this.groupOptExe.Controls.Add(this.buttonCommandLineHelp);
			this.groupOptExe.Controls.Add(this.label2);
			this.groupOptExe.Controls.Add(this.textCommandLine);
			this.groupOptExe.Controls.Add(this.buttonExeBrowse);
			this.groupOptExe.Controls.Add(this.checkShowConsole);
			this.groupOptExe.Controls.Add(this.labelOptExe);
			this.groupOptExe.Controls.Add(this.textExecutable);
			this.groupOptExe.Location = new System.Drawing.Point(3, 73);
			this.groupOptExe.Name = "groupOptExe";
			this.groupOptExe.Size = new System.Drawing.Size(208, 139);
			this.groupOptExe.TabIndex = 2;
			this.groupOptExe.TabStop = false;
			this.groupOptExe.Text = "Misc.";
			// 
			// buttonCommandLineHelp
			// 
			this.buttonCommandLineHelp.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonCommandLineHelp.Location = new System.Drawing.Point(176, 94);
			this.buttonCommandLineHelp.Name = "buttonCommandLineHelp";
			this.buttonCommandLineHelp.Size = new System.Drawing.Size(26, 20);
			this.buttonCommandLineHelp.TabIndex = 5;
			this.buttonCommandLineHelp.Text = "?";
			this.toolTip.SetToolTip(this.buttonCommandLineHelp, "SRB2 Wiki page for command-line arguments.");
			this.buttonCommandLineHelp.UseVisualStyleBackColor = true;
			this.buttonCommandLineHelp.Click += new System.EventHandler(this.buttonCommandLineHelp_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 78);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Custom parameters:";
			// 
			// textCommandLine
			// 
			this.textCommandLine.Location = new System.Drawing.Point(6, 94);
			this.textCommandLine.Name = "textCommandLine";
			this.textCommandLine.Size = new System.Drawing.Size(164, 20);
			this.textCommandLine.TabIndex = 4;
			this.textCommandLine.Click += new System.EventHandler(this.textOptCmd_Click);
			// 
			// buttonExeBrowse
			// 
			this.buttonExeBrowse.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonExeBrowse.Location = new System.Drawing.Point(176, 55);
			this.buttonExeBrowse.Name = "buttonExeBrowse";
			this.buttonExeBrowse.Size = new System.Drawing.Size(26, 20);
			this.buttonExeBrowse.TabIndex = 3;
			this.buttonExeBrowse.Text = "...";
			this.toolTip.SetToolTip(this.buttonExeBrowse, "Browse for a .exe to use.");
			this.buttonExeBrowse.UseVisualStyleBackColor = true;
			this.buttonExeBrowse.Click += new System.EventHandler(this.buttonExeBrowse_Click);
			// 
			// checkShowConsole
			// 
			this.checkShowConsole.AutoSize = true;
			this.checkShowConsole.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkShowConsole.Location = new System.Drawing.Point(6, 19);
			this.checkShowConsole.Name = "checkShowConsole";
			this.checkShowConsole.Size = new System.Drawing.Size(138, 18);
			this.checkShowConsole.TabIndex = 0;
			this.checkShowConsole.Text = "Show console window";
			this.toolTip.SetToolTip(this.checkShowConsole, "Creates a separate console window to show the SRB2 console\'s\r\noutput and allows c" +
        "onsole commands to be entered.");
			this.checkShowConsole.UseVisualStyleBackColor = true;
			// 
			// labelOptExe
			// 
			this.labelOptExe.AutoSize = true;
			this.labelOptExe.Location = new System.Drawing.Point(6, 39);
			this.labelOptExe.Name = "labelOptExe";
			this.labelOptExe.Size = new System.Drawing.Size(101, 13);
			this.labelOptExe.TabIndex = 1;
			this.labelOptExe.Text = "Custom Executable:";
			// 
			// textExecutable
			// 
			this.textExecutable.Location = new System.Drawing.Point(6, 55);
			this.textExecutable.Name = "textExecutable";
			this.textExecutable.Size = new System.Drawing.Size(164, 20);
			this.textExecutable.TabIndex = 2;
			this.textExecutable.Text = "srb2win.exe";
			this.textExecutable.Leave += new System.EventHandler(this.textExeName_Leave);
			// 
			// groupOptSound
			// 
			this.groupOptSound.Controls.Add(this.groupMusicType);
			this.groupOptSound.Controls.Add(this.checkEnableBGM);
			this.groupOptSound.Controls.Add(this.checkEnableSFX);
			this.groupOptSound.Location = new System.Drawing.Point(217, 73);
			this.groupOptSound.Name = "groupOptSound";
			this.groupOptSound.Size = new System.Drawing.Size(110, 139);
			this.groupOptSound.TabIndex = 3;
			this.groupOptSound.TabStop = false;
			this.groupOptSound.Text = "Sound";
			// 
			// groupMusicType
			// 
			this.groupMusicType.Controls.Add(this.checkMusicMIDI);
			this.groupMusicType.Controls.Add(this.checkMusicDIGI);
			this.groupMusicType.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupMusicType.Location = new System.Drawing.Point(3, 69);
			this.groupMusicType.Margin = new System.Windows.Forms.Padding(0);
			this.groupMusicType.Name = "groupMusicType";
			this.groupMusicType.Size = new System.Drawing.Size(104, 67);
			this.groupMusicType.TabIndex = 2;
			this.groupMusicType.TabStop = false;
			this.groupMusicType.Text = "Music types";
			// 
			// checkMusicMIDI
			// 
			this.checkMusicMIDI.AutoSize = true;
			this.checkMusicMIDI.Checked = true;
			this.checkMusicMIDI.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkMusicMIDI.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkMusicMIDI.Location = new System.Drawing.Point(6, 42);
			this.checkMusicMIDI.Name = "checkMusicMIDI";
			this.checkMusicMIDI.Size = new System.Drawing.Size(55, 18);
			this.checkMusicMIDI.TabIndex = 1;
			this.checkMusicMIDI.Text = "MIDI";
			this.toolTip.SetToolTip(this.checkMusicMIDI, "Enables MIDI music.\r\nIf disabled, it can be re-enabled in the ingame options.");
			this.checkMusicMIDI.UseVisualStyleBackColor = true;
			this.checkMusicMIDI.CheckStateChanged += new System.EventHandler(this.MusicTypeCheck);
			// 
			// checkMusicDIGI
			// 
			this.checkMusicDIGI.AutoSize = true;
			this.checkMusicDIGI.Checked = true;
			this.checkMusicDIGI.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkMusicDIGI.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkMusicDIGI.Location = new System.Drawing.Point(6, 19);
			this.checkMusicDIGI.Name = "checkMusicDIGI";
			this.checkMusicDIGI.Size = new System.Drawing.Size(61, 18);
			this.checkMusicDIGI.TabIndex = 0;
			this.checkMusicDIGI.Text = "Digital";
			this.toolTip.SetToolTip(this.checkMusicDIGI, "Enables digital music (OGG, MP3, etc).\r\nIf disabled, it can be re-enabled in the " +
        "ingame options.");
			this.checkMusicDIGI.UseVisualStyleBackColor = true;
			this.checkMusicDIGI.CheckStateChanged += new System.EventHandler(this.MusicTypeCheck);
			// 
			// checkEnableBGM
			// 
			this.checkEnableBGM.AutoSize = true;
			this.checkEnableBGM.Checked = true;
			this.checkEnableBGM.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkEnableBGM.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkEnableBGM.Location = new System.Drawing.Point(7, 43);
			this.checkEnableBGM.Name = "checkEnableBGM";
			this.checkEnableBGM.Size = new System.Drawing.Size(96, 18);
			this.checkEnableBGM.TabIndex = 1;
			this.checkEnableBGM.Text = "Enable Music";
			this.toolTip.SetToolTip(this.checkEnableBGM, "Enables ingame music.\r\nIf disabled, it can be re-enabled in the ingame options.");
			this.checkEnableBGM.UseVisualStyleBackColor = true;
			this.checkEnableBGM.CheckedChanged += new System.EventHandler(this.onCheck_checkEnableBGM);
			// 
			// checkEnableSFX
			// 
			this.checkEnableSFX.AutoSize = true;
			this.checkEnableSFX.Checked = true;
			this.checkEnableSFX.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkEnableSFX.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkEnableSFX.Location = new System.Drawing.Point(7, 20);
			this.checkEnableSFX.Name = "checkEnableSFX";
			this.checkEnableSFX.Size = new System.Drawing.Size(104, 18);
			this.checkEnableSFX.TabIndex = 0;
			this.checkEnableSFX.Text = "Enable Sounds";
			this.toolTip.SetToolTip(this.checkEnableSFX, "Enables sound effects.\r\nIf disabled, it can be re-enabled in the ingame options.");
			this.checkEnableSFX.UseVisualStyleBackColor = true;
			// 
			// groupWarp
			// 
			this.groupWarp.Controls.Add(this.checkEnableWarp);
			this.groupWarp.Controls.Add(this.label11);
			this.groupWarp.Controls.Add(this.label12);
			this.groupWarp.Controls.Add(this.textWarpMapNum);
			this.groupWarp.Controls.Add(this.comboWarpGametype);
			this.groupWarp.Location = new System.Drawing.Point(3, 218);
			this.groupWarp.Name = "groupWarp";
			this.groupWarp.Size = new System.Drawing.Size(208, 90);
			this.groupWarp.TabIndex = 4;
			this.groupWarp.TabStop = false;
			this.groupWarp.Text = "Warp to map";
			// 
			// checkEnableWarp
			// 
			this.checkEnableWarp.AutoSize = true;
			this.checkEnableWarp.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkEnableWarp.Location = new System.Drawing.Point(6, 19);
			this.checkEnableWarp.Name = "checkEnableWarp";
			this.checkEnableWarp.Size = new System.Drawing.Size(91, 18);
			this.checkEnableWarp.TabIndex = 0;
			this.checkEnableWarp.Text = "Enable warp";
			this.toolTip.SetToolTip(this.checkEnableWarp, "Warp directly to a map when SRB2 starts.\r\nDisables and is disabled by Join or Hos" +
        "t Netgame.");
			this.checkEnableWarp.UseVisualStyleBackColor = true;
			this.checkEnableWarp.CheckedChanged += new System.EventHandler(this.onCheck_checkEnableWarp);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(6, 40);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(69, 13);
			this.label11.TabIndex = 3;
			this.label11.Text = "Map number:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(17, 66);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(58, 13);
			this.label12.TabIndex = 6;
			this.label12.Text = "Gametype:";
			// 
			// textWarpMapNum
			// 
			this.textWarpMapNum.Enabled = false;
			this.textWarpMapNum.Location = new System.Drawing.Point(81, 37);
			this.textWarpMapNum.MaxLength = 4;
			this.textWarpMapNum.Name = "textWarpMapNum";
			this.textWarpMapNum.Size = new System.Drawing.Size(42, 20);
			this.textWarpMapNum.TabIndex = 1;
			this.textWarpMapNum.Text = "01";
			this.toolTip.SetToolTip(this.textWarpMapNum, "Specifies which map to warp to on startup.\r\n");
			this.textWarpMapNum.Click += new System.EventHandler(this.TextGainFocus);
			this.textWarpMapNum.TextChanged += new System.EventHandler(this.onTextChanged_textWarpMapNum);
			this.textWarpMapNum.Enter += new System.EventHandler(this.TextGainFocus);
			// 
			// comboWarpGametype
			// 
			this.comboWarpGametype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboWarpGametype.Enabled = false;
			this.comboWarpGametype.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.comboWarpGametype.FormattingEnabled = true;
			this.comboWarpGametype.Items.AddRange(new object[] {
            "derp"});
			this.comboWarpGametype.Location = new System.Drawing.Point(81, 63);
			this.comboWarpGametype.Name = "comboWarpGametype";
			this.comboWarpGametype.Size = new System.Drawing.Size(121, 21);
			this.comboWarpGametype.TabIndex = 2;
			// 
			// buttonLaunch
			// 
			this.buttonLaunch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonLaunch.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonLaunch.Location = new System.Drawing.Point(281, 377);
			this.buttonLaunch.Name = "buttonLaunch";
			this.buttonLaunch.Size = new System.Drawing.Size(75, 23);
			this.buttonLaunch.TabIndex = 1000;
			this.buttonLaunch.Text = "&Launch";
			this.toolTip.SetToolTip(this.buttonLaunch, "Launch SRB2 already!");
			this.buttonLaunch.UseVisualStyleBackColor = true;
			this.buttonLaunch.Click += new System.EventHandler(this.buttonLaunch_Click);
			// 
			// addFileDialog
			// 
			this.addFileDialog.DefaultExt = "wad";
			this.addFileDialog.Filter = resources.GetString("addFileDialog.Filter");
			this.addFileDialog.Multiselect = true;
			this.addFileDialog.Title = "Add files";
			// 
			// openExeDialog
			// 
			this.openExeDialog.DefaultExt = "exe";
			this.openExeDialog.Filter = "EXE files|*.exe|All files|*.*";
			this.openExeDialog.Title = "Select an executable";
			// 
			// saveFileListDialog
			// 
			this.saveFileListDialog.DefaultExt = "ini";
			this.saveFileListDialog.Filter = "INI files|*.ini|All files|*.*";
			this.saveFileListDialog.Title = "Save file list as...";
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(368, 24);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "menuStrip";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearFileListToolStripMenuItem,
            this.openFileListToolStripMenuItem,
            this.saveFileListToolStripMenuItem,
            this.saveFileListAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.openSRB2FolderToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// clearFileListToolStripMenuItem
			// 
			this.clearFileListToolStripMenuItem.Name = "clearFileListToolStripMenuItem";
			this.clearFileListToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+N";
			this.clearFileListToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.clearFileListToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
			this.clearFileListToolStripMenuItem.Text = "New";
			this.clearFileListToolStripMenuItem.Click += new System.EventHandler(this.clearFileListToolStripMenuItem_Click);
			// 
			// openFileListToolStripMenuItem
			// 
			this.openFileListToolStripMenuItem.Name = "openFileListToolStripMenuItem";
			this.openFileListToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+O";
			this.openFileListToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.openFileListToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
			this.openFileListToolStripMenuItem.Text = "Open...";
			this.openFileListToolStripMenuItem.Click += new System.EventHandler(this.openFileListToolStripMenuItem_Click);
			// 
			// saveFileListToolStripMenuItem
			// 
			this.saveFileListToolStripMenuItem.Enabled = false;
			this.saveFileListToolStripMenuItem.Name = "saveFileListToolStripMenuItem";
			this.saveFileListToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+S";
			this.saveFileListToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.saveFileListToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
			this.saveFileListToolStripMenuItem.Text = "Save";
			this.saveFileListToolStripMenuItem.Click += new System.EventHandler(this.saveFileListToolStripMenuItem_Click);
			// 
			// saveFileListAsToolStripMenuItem
			// 
			this.saveFileListAsToolStripMenuItem.Name = "saveFileListAsToolStripMenuItem";
			this.saveFileListAsToolStripMenuItem.ShortcutKeyDisplayString = "";
			this.saveFileListAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
			this.saveFileListAsToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
			this.saveFileListAsToolStripMenuItem.Text = "Save As...";
			this.saveFileListAsToolStripMenuItem.Click += new System.EventHandler(this.saveFileListAsToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(213, 6);
			// 
			// openSRB2FolderToolStripMenuItem
			// 
			this.openSRB2FolderToolStripMenuItem.Name = "openSRB2FolderToolStripMenuItem";
			this.openSRB2FolderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
			this.openSRB2FolderToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
			this.openSRB2FolderToolStripMenuItem.Text = "Open SRB2 Folder...";
			this.openSRB2FolderToolStripMenuItem.Click += new System.EventHandler(this.openSRB2FolderToolStripMenuItem_Click);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSettings,
            this.toolStripDragDropFilter});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// toolStripSettings
			// 
			this.toolStripSettings.Name = "toolStripSettings";
			this.toolStripSettings.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
			this.toolStripSettings.Size = new System.Drawing.Size(208, 22);
			this.toolStripSettings.Text = "Advanced Settings";
			this.toolStripSettings.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
			// 
			// toolStripDragDropFilter
			// 
			this.toolStripDragDropFilter.Name = "toolStripDragDropFilter";
			this.toolStripDragDropFilter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
			this.toolStripDragDropFilter.Size = new System.Drawing.Size(208, 22);
			this.toolStripDragDropFilter.Text = "Drag && Drop Filter";
			this.toolStripDragDropFilter.Click += new System.EventHandler(this.dragDropFilterToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.ShortcutKeyDisplayString = "F1";
			this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click_1);
			// 
			// openFileListDialog
			// 
			this.openFileListDialog.DefaultExt = "ini";
			this.openFileListDialog.Filter = "INI files|*.ini|All files|*.*";
			this.openFileListDialog.Multiselect = true;
			this.openFileListDialog.Title = "Open file list";
			// 
			// MainWindow
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(368, 410);
			this.Controls.Add(this.buttonLaunch);
			this.Controls.Add(this.tabControlMain);
			this.Controls.Add(this.menuStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip;
			this.Name = "MainWindow";
			this.Text = "Title";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
			this.Load += new System.EventHandler(this.MainWindow_Load);
			this.tabControlMain.ResumeLayout(false);
			this.tabPageFiles.ResumeLayout(false);
			this.tabPageNetplay.ResumeLayout(false);
			this.tabNetplay.ResumeLayout(false);
			this.tabPageNetJoin.ResumeLayout(false);
			this.tabPageNetJoin.PerformLayout();
			this.flowLayoutPanel3.ResumeLayout(false);
			this.groupJoinBasic.ResumeLayout(false);
			this.groupJoinBasic.PerformLayout();
			this.groupJoinAdvanced.ResumeLayout(false);
			this.groupJoinAdvanced.PerformLayout();
			this.tabPageNetHost.ResumeLayout(false);
			this.tabPageNetHost.PerformLayout();
			this.flowLayoutPanel2.ResumeLayout(false);
			this.groupHostBasic.ResumeLayout(false);
			this.groupHostBasic.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericMaxPlayers)).EndInit();
			this.groupHostAdv.ResumeLayout(false);
			this.groupHostAdv.PerformLayout();
			this.tabPageOptions.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.groupOptRes.ResumeLayout(false);
			this.groupOptRes.PerformLayout();
			this.groupOptRend.ResumeLayout(false);
			this.groupOptRend.PerformLayout();
			this.groupOptExe.ResumeLayout(false);
			this.groupOptExe.PerformLayout();
			this.groupOptSound.ResumeLayout(false);
			this.groupOptSound.PerformLayout();
			this.groupMusicType.ResumeLayout(false);
			this.groupMusicType.PerformLayout();
			this.groupWarp.ResumeLayout(false);
			this.groupWarp.PerformLayout();
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TabControl tabControlMain;
		private TabPage tabPageFiles;
		private TabPage tabPageNetplay;
		private TabPage tabPageOptions;
		private Button buttonLaunch;
		private TabControl tabNetplay;
		private TabPage tabPageNetJoin;
		private GroupBox groupJoinBasic;
		private CheckBox checkNoFiles;
		private CheckBox checkNoDownload;
		private TextBox textJoinIPAddress;
		private Label label9;
		private CheckBox checkJoinNetgame;
		private TabPage tabPageNetHost;
		private CheckBox checkHostNetgame;
		private GroupBox groupHostAdv;
		private CheckBox checkHostOnline;
		private CheckBox checkHostDedicated;
		private GroupBox groupHostBasic;
		private Label label8;
		private RadioButton radioHostCasualRoom;
		private RadioButton radioHostStandardRoom;
		private Label label3;
		private Label label5;
		private TextBox textHostMapNum;
		private ComboBox comboHostGametype;
		private GroupBox groupOptRend;
		private RadioButton radioRendOpenGL;
		private RadioButton radioRendSoftware;
		private GroupBox groupOptExe;
		private Label labelOptExe;
		private TextBox textExecutable;
		private GroupBox groupOptSound;
		private GroupBox groupMusicType;
		private CheckBox checkEnableBGM;
		private CheckBox checkEnableSFX;
		private GroupBox groupOptRes;
		private TextBox textScreenHeight;
		private CheckBox checkCustomResolution;
		private TextBox textScreenWidth;
		private CheckBox checkWindowedMode;
		private Label labelOptRes;
		private CheckBox checkMusicMIDI;
		private CheckBox checkMusicDIGI;
		private ToolTip toolTip;
		private GroupBox groupWarp;
		private CheckBox checkEnableWarp;
		private Label label11;
		private Label label12;
		private TextBox textWarpMapNum;
		private ComboBox comboWarpGametype;
		private TextBox textJoinPortNum;
		private Label label7;
		private TextBox textHostPass;
		private Label label1;
		private CheckBox checkHostFileDownload;
		private GroupBox groupJoinAdvanced;
		private Button buttonFileRemove;
		private ListView listFiles;
		private Button buttonFileAdd;
		private CheckBox checkShowConsole;
		private Button buttonFileDown;
		private Button buttonFileUp;
		private Label label6;
		private Label label4;
		private NumericUpDown numericMaxPlayers;
		private TextBox textServerName;
		private OpenFileDialog addFileDialog;
		private Button buttonExeBrowse;
		private OpenFileDialog openExeDialog;
		private SaveFileDialog saveFileListDialog;
		private MenuStrip menuStrip;
		private ToolStripMenuItem fileToolStripMenuItem;
		private ToolStripMenuItem helpToolStripMenuItem;
		private ToolStripMenuItem aboutToolStripMenuItem;
		private ToolStripMenuItem openFileListToolStripMenuItem;
		private ToolStripMenuItem saveFileListToolStripMenuItem;
		private ToolStripMenuItem saveFileListAsToolStripMenuItem;
		private ColumnHeader columnFiles;
		private OpenFileDialog openFileListDialog;
		private ToolStripMenuItem clearFileListToolStripMenuItem;
		private TextBox textCommandLine;
		private ToolStripMenuItem editToolStripMenuItem;
		private ToolStripMenuItem toolStripSettings;
		private ToolStripMenuItem toolStripDragDropFilter;
		private ToolStripMenuItem openSRB2FolderToolStripMenuItem;
		private ToolStripSeparator toolStripSeparator1;
		private Button buttonCommandLineHelp;
		private Label label2;
		private FlowLayoutPanel flowLayoutPanel1;
		private FlowLayoutPanel flowLayoutPanel2;
		private FlowLayoutPanel flowLayoutPanel3;
	}
}

