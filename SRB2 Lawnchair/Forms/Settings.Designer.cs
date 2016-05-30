using System.ComponentModel;
using System.Windows.Forms;

namespace Lawnchair.Forms
{
	partial class Settings
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
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.checkMinimizeOnLaunch = new System.Windows.Forms.CheckBox();
			this.groupGameOptions = new System.Windows.Forms.GroupBox();
			this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.buttonDConfigBrowse = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.textDConfigPath = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textConfigPath = new System.Windows.Forms.TextBox();
			this.buttonConfigBrowse = new System.Windows.Forms.Button();
			this.groupLauncherOptions = new System.Windows.Forms.GroupBox();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.comboGameVersion = new System.Windows.Forms.ComboBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.openConfigDialog = new System.Windows.Forms.OpenFileDialog();
			this.groupGameOptions.SuspendLayout();
			this.flowLayoutPanel3.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.groupLauncherOptions.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonOK
			// 
			this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonOK.Location = new System.Drawing.Point(174, 278);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 1;
			this.buttonOK.Text = "&OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonCancel.Location = new System.Drawing.Point(255, 278);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 2;
			this.buttonCancel.Text = "&Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// checkMinimizeOnLaunch
			// 
			this.checkMinimizeOnLaunch.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.checkMinimizeOnLaunch.AutoSize = true;
			this.checkMinimizeOnLaunch.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkMinimizeOnLaunch.Location = new System.Drawing.Point(3, 3);
			this.checkMinimizeOnLaunch.Name = "checkMinimizeOnLaunch";
			this.checkMinimizeOnLaunch.Size = new System.Drawing.Size(122, 18);
			this.checkMinimizeOnLaunch.TabIndex = 0;
			this.checkMinimizeOnLaunch.Text = "Minimize on launch";
			this.toolTip1.SetToolTip(this.checkMinimizeOnLaunch, "Minimizes the main launcher window when the game launches, and restores when the " +
        "game quits.");
			this.checkMinimizeOnLaunch.UseVisualStyleBackColor = true;
			// 
			// groupGameOptions
			// 
			this.groupGameOptions.Controls.Add(this.flowLayoutPanel3);
			this.groupGameOptions.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupGameOptions.Location = new System.Drawing.Point(3, 133);
			this.groupGameOptions.Name = "groupGameOptions";
			this.groupGameOptions.Size = new System.Drawing.Size(310, 124);
			this.groupGameOptions.TabIndex = 1;
			this.groupGameOptions.TabStop = false;
			this.groupGameOptions.Text = "Game Options";
			// 
			// flowLayoutPanel3
			// 
			this.flowLayoutPanel3.Controls.Add(this.tableLayoutPanel3);
			this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 16);
			this.flowLayoutPanel3.Name = "flowLayoutPanel3";
			this.flowLayoutPanel3.Size = new System.Drawing.Size(304, 105);
			this.flowLayoutPanel3.TabIndex = 0;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.AutoSize = true;
			this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel3.ColumnCount = 3;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel3.Controls.Add(this.buttonDConfigBrowse, 2, 1);
			this.tableLayoutPanel3.Controls.Add(this.label3, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.textDConfigPath, 1, 1);
			this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.textConfigPath, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.buttonConfigBrowse, 2, 0);
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 2;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.Size = new System.Drawing.Size(298, 56);
			this.tableLayoutPanel3.TabIndex = 0;
			// 
			// buttonDConfigBrowse
			// 
			this.buttonDConfigBrowse.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonDConfigBrowse.AutoSize = true;
			this.buttonDConfigBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.buttonDConfigBrowse.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonDConfigBrowse.Location = new System.Drawing.Point(265, 31);
			this.buttonDConfigBrowse.Name = "buttonDConfigBrowse";
			this.buttonDConfigBrowse.Size = new System.Drawing.Size(30, 22);
			this.buttonDConfigBrowse.TabIndex = 5;
			this.buttonDConfigBrowse.Text = "...";
			this.buttonDConfigBrowse.UseVisualStyleBackColor = true;
			this.buttonDConfigBrowse.Click += new System.EventHandler(this.buttonDConfigBrowse_Click);
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 35);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(92, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Dedicated Config:";
			// 
			// textDConfigPath
			// 
			this.textDConfigPath.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textDConfigPath.Location = new System.Drawing.Point(101, 31);
			this.textDConfigPath.Name = "textDConfigPath";
			this.textDConfigPath.Size = new System.Drawing.Size(158, 20);
			this.textDConfigPath.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(17, 7);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Custom Config:";
			// 
			// textConfigPath
			// 
			this.textConfigPath.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textConfigPath.Location = new System.Drawing.Point(101, 3);
			this.textConfigPath.Name = "textConfigPath";
			this.textConfigPath.Size = new System.Drawing.Size(158, 20);
			this.textConfigPath.TabIndex = 1;
			// 
			// buttonConfigBrowse
			// 
			this.buttonConfigBrowse.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.buttonConfigBrowse.AutoSize = true;
			this.buttonConfigBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.buttonConfigBrowse.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonConfigBrowse.Location = new System.Drawing.Point(265, 3);
			this.buttonConfigBrowse.Name = "buttonConfigBrowse";
			this.buttonConfigBrowse.Size = new System.Drawing.Size(30, 22);
			this.buttonConfigBrowse.TabIndex = 2;
			this.buttonConfigBrowse.Text = "...";
			this.buttonConfigBrowse.UseVisualStyleBackColor = true;
			this.buttonConfigBrowse.Click += new System.EventHandler(this.buttonConfigBrowse_Click);
			// 
			// groupLauncherOptions
			// 
			this.groupLauncherOptions.Controls.Add(this.flowLayoutPanel1);
			this.groupLauncherOptions.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupLauncherOptions.Location = new System.Drawing.Point(3, 3);
			this.groupLauncherOptions.Name = "groupLauncherOptions";
			this.groupLauncherOptions.Size = new System.Drawing.Size(310, 124);
			this.groupLauncherOptions.TabIndex = 0;
			this.groupLauncherOptions.TabStop = false;
			this.groupLauncherOptions.Text = "Launcher Options";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.checkMinimizeOnLaunch);
			this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
			this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel2);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(304, 105);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.flowLayoutPanel2.AutoSize = true;
			this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flowLayoutPanel2.Location = new System.Drawing.Point(131, 12);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(0, 0);
			this.flowLayoutPanel2.TabIndex = 2;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.AutoSize = true;
			this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.comboGameVersion, 1, 0);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 27);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(208, 27);
			this.tableLayoutPanel2.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Game Version:";
			// 
			// comboGameVersion
			// 
			this.comboGameVersion.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.comboGameVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboGameVersion.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.comboGameVersion.FormattingEnabled = true;
			this.comboGameVersion.Items.AddRange(new object[] {
            "2.1.X",
            "2.0.X",
            "1.09.X & Below"});
			this.comboGameVersion.Location = new System.Drawing.Point(85, 3);
			this.comboGameVersion.Name = "comboGameVersion";
			this.comboGameVersion.Size = new System.Drawing.Size(120, 21);
			this.comboGameVersion.TabIndex = 1;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.groupLauncherOptions, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.groupGameOptions, 0, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(316, 260);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// openConfigDialog
			// 
			this.openConfigDialog.Filter = "CFG files|*.cfg";
			// 
			// Settings
			// 
			this.AcceptButton = this.buttonOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(340, 310);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOK);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Settings";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Advanced Settings";
			this.Load += new System.EventHandler(this.Settings_Load);
			this.groupGameOptions.ResumeLayout(false);
			this.flowLayoutPanel3.ResumeLayout(false);
			this.flowLayoutPanel3.PerformLayout();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.groupLauncherOptions.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Button buttonOK;
		private Button buttonCancel;
		private ToolTip toolTip1;
		private GroupBox groupGameOptions;
		private GroupBox groupLauncherOptions;
		private FlowLayoutPanel flowLayoutPanel1;
		private CheckBox checkMinimizeOnLaunch;
		private TableLayoutPanel tableLayoutPanel1;
		private Label label1;
		private FlowLayoutPanel flowLayoutPanel2;
		private ComboBox comboGameVersion;
		private FlowLayoutPanel flowLayoutPanel3;
		private TableLayoutPanel tableLayoutPanel3;
		private Button buttonDConfigBrowse;
		private Label label3;
		private TextBox textDConfigPath;
		private Label label2;
		private TextBox textConfigPath;
		private Button buttonConfigBrowse;
		private TableLayoutPanel tableLayoutPanel2;
		private OpenFileDialog openConfigDialog;
	}
}