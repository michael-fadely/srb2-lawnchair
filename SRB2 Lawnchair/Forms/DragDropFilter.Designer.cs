using System.ComponentModel;
using System.Windows.Forms;

namespace Lawnchair.Forms
{
	partial class DragDropFilter
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DragDropFilter));
			this.radioEnableDropFilter = new System.Windows.Forms.RadioButton();
			this.radioDisableDropFilter = new System.Windows.Forms.RadioButton();
			this.groupDefaultFileExtensions = new System.Windows.Forms.GroupBox();
			this.DragDropDefaultFilters = new System.Windows.Forms.CheckedListBox();
			this.buttonDelFilter = new System.Windows.Forms.Button();
			this.buttonAddFilter = new System.Windows.Forms.Button();
			this.DragDropCustomFilters = new System.Windows.Forms.CheckedListBox();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.groupCustomFileExtensions = new System.Windows.Forms.GroupBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.groupDefaultFileExtensions.SuspendLayout();
			this.groupCustomFileExtensions.SuspendLayout();
			this.SuspendLayout();
			// 
			// radioEnableDropFilter
			// 
			this.radioEnableDropFilter.AutoSize = true;
			this.radioEnableDropFilter.Checked = true;
			this.radioEnableDropFilter.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.radioEnableDropFilter.Location = new System.Drawing.Point(12, 35);
			this.radioEnableDropFilter.Name = "radioEnableDropFilter";
			this.radioEnableDropFilter.Size = new System.Drawing.Size(199, 18);
			this.radioEnableDropFilter.TabIndex = 1;
			this.radioEnableDropFilter.TabStop = true;
			this.radioEnableDropFilter.Text = "Restrict dropped files to these types";
			this.radioEnableDropFilter.UseVisualStyleBackColor = true;
			this.radioEnableDropFilter.CheckedChanged += new System.EventHandler(this.radioEnableDropFilter_CheckedChanged);
			// 
			// radioDisableDropFilter
			// 
			this.radioDisableDropFilter.AutoSize = true;
			this.radioDisableDropFilter.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.radioDisableDropFilter.Location = new System.Drawing.Point(12, 12);
			this.radioDisableDropFilter.Name = "radioDisableDropFilter";
			this.radioDisableDropFilter.Size = new System.Drawing.Size(206, 18);
			this.radioDisableDropFilter.TabIndex = 0;
			this.radioDisableDropFilter.Text = "Allow all filetypes (Not recommended)";
			this.radioDisableDropFilter.UseVisualStyleBackColor = true;
			// 
			// groupDefaultFileExtensions
			// 
			this.groupDefaultFileExtensions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupDefaultFileExtensions.Controls.Add(this.DragDropDefaultFilters);
			this.groupDefaultFileExtensions.Location = new System.Drawing.Point(12, 58);
			this.groupDefaultFileExtensions.Name = "groupDefaultFileExtensions";
			this.groupDefaultFileExtensions.Size = new System.Drawing.Size(284, 141);
			this.groupDefaultFileExtensions.TabIndex = 2;
			this.groupDefaultFileExtensions.TabStop = false;
			this.groupDefaultFileExtensions.Text = "Default File Extensions";
			// 
			// DragDropDefaultFilters
			// 
			this.DragDropDefaultFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DragDropDefaultFilters.FormattingEnabled = true;
			this.DragDropDefaultFilters.Items.AddRange(new object[] {
            ".wad",
            ".soc",
            ".lua",
            ".srb",
            ".dta",
            ".plr",
            ".wpn"});
			this.DragDropDefaultFilters.Location = new System.Drawing.Point(6, 19);
			this.DragDropDefaultFilters.Name = "DragDropDefaultFilters";
			this.DragDropDefaultFilters.Size = new System.Drawing.Size(272, 109);
			this.DragDropDefaultFilters.TabIndex = 0;
			// 
			// buttonDelFilter
			// 
			this.buttonDelFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonDelFilter.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonDelFilter.Location = new System.Drawing.Point(254, 49);
			this.buttonDelFilter.Name = "buttonDelFilter";
			this.buttonDelFilter.Size = new System.Drawing.Size(24, 24);
			this.buttonDelFilter.TabIndex = 2;
			this.buttonDelFilter.Text = "-";
			this.toolTip1.SetToolTip(this.buttonDelFilter, "Remove selected filter (Not checked!)");
			this.buttonDelFilter.UseVisualStyleBackColor = true;
			this.buttonDelFilter.Click += new System.EventHandler(this.buttonDelFilter_Click);
			// 
			// buttonAddFilter
			// 
			this.buttonAddFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonAddFilter.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonAddFilter.Location = new System.Drawing.Point(254, 19);
			this.buttonAddFilter.Name = "buttonAddFilter";
			this.buttonAddFilter.Size = new System.Drawing.Size(24, 24);
			this.buttonAddFilter.TabIndex = 1;
			this.buttonAddFilter.Text = "+";
			this.toolTip1.SetToolTip(this.buttonAddFilter, "Add a custom filter");
			this.buttonAddFilter.UseVisualStyleBackColor = true;
			this.buttonAddFilter.Click += new System.EventHandler(this.buttonAddFilter_Click);
			// 
			// DragDropCustomFilters
			// 
			this.DragDropCustomFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DragDropCustomFilters.FormattingEnabled = true;
			this.DragDropCustomFilters.Location = new System.Drawing.Point(6, 19);
			this.DragDropCustomFilters.Name = "DragDropCustomFilters";
			this.DragDropCustomFilters.Size = new System.Drawing.Size(242, 94);
			this.DragDropCustomFilters.TabIndex = 0;
			// 
			// buttonOK
			// 
			this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonOK.Location = new System.Drawing.Point(136, 330);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 4;
			this.buttonOK.Text = "&OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonCancel.Location = new System.Drawing.Point(221, 330);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 5;
			this.buttonCancel.Text = "&Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// groupCustomFileExtensions
			// 
			this.groupCustomFileExtensions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupCustomFileExtensions.Controls.Add(this.DragDropCustomFilters);
			this.groupCustomFileExtensions.Controls.Add(this.buttonAddFilter);
			this.groupCustomFileExtensions.Controls.Add(this.buttonDelFilter);
			this.groupCustomFileExtensions.Location = new System.Drawing.Point(12, 205);
			this.groupCustomFileExtensions.Name = "groupCustomFileExtensions";
			this.groupCustomFileExtensions.Size = new System.Drawing.Size(284, 119);
			this.groupCustomFileExtensions.TabIndex = 3;
			this.groupCustomFileExtensions.TabStop = false;
			this.groupCustomFileExtensions.Text = "Custom File Extensions";
			// 
			// DragDropFilter
			// 
			this.AcceptButton = this.buttonOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(308, 365);
			this.Controls.Add(this.groupCustomFileExtensions);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.groupDefaultFileExtensions);
			this.Controls.Add(this.radioDisableDropFilter);
			this.Controls.Add(this.radioEnableDropFilter);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(320, 377);
			this.Name = "DragDropFilter";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Drag & Drop Filter Options";
			this.groupDefaultFileExtensions.ResumeLayout(false);
			this.groupCustomFileExtensions.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private RadioButton radioEnableDropFilter;
		private RadioButton radioDisableDropFilter;
		private GroupBox groupDefaultFileExtensions;
		private CheckedListBox DragDropCustomFilters;
		private Button buttonDelFilter;
		private Button buttonAddFilter;
		private Button buttonOK;
		private Button buttonCancel;
		private CheckedListBox DragDropDefaultFilters;
		private GroupBox groupCustomFileExtensions;
		private ToolTip toolTip1;
	}
}