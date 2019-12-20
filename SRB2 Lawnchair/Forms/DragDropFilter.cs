using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lawnchair.Forms
{
	public partial class DragDropFilter : Form
	{
		public static bool IsFilterEnabled;

		private NewDragDropFilter NewFilter;
		public  LawnchairSettings Settings { get; }

		public DragDropFilter(LawnchairSettings settings)
		{
			InitializeComponent();

			// Check all the default items in the default filter list
			for (int i = 0; i < DragDropDefaultFilters.Items.Count; i++)
			{
				DragDropDefaultFilters.SetItemCheckState(i, CheckState.Checked);
			}

			Settings = settings;

			LoadFilters();
		}

		private void SaveFilters()
		{
			Settings.Filters.Enabled = radioEnableDropFilter.Checked;
			IsFilterEnabled          = radioEnableDropFilter.Checked;

			int n = 0;

			Settings.Filters.AllowPK3 = DragDropDefaultFilters.GetItemChecked(n++);
			Settings.Filters.AllowWAD = DragDropDefaultFilters.GetItemChecked(n++);
			Settings.Filters.AllowSOC = DragDropDefaultFilters.GetItemChecked(n++);
			Settings.Filters.AllowLua = DragDropDefaultFilters.GetItemChecked(n++);
			Settings.Filters.AllowSRB = DragDropDefaultFilters.GetItemChecked(n++);
			Settings.Filters.AllowDTA = DragDropDefaultFilters.GetItemChecked(n++);
			Settings.Filters.AllowPLR = DragDropDefaultFilters.GetItemChecked(n++);
			Settings.Filters.AllowWPN = DragDropDefaultFilters.GetItemChecked(n);

			Settings.Filters.CustomFilters = new Dictionary<string, bool>();

			for (int i = 0; i < DragDropCustomFilters.Items.Count; i++)
			{
				Settings.Filters.CustomFilters.Add(DragDropCustomFilters.Items[i].ToString(),
				                                   DragDropCustomFilters.GetItemChecked(i));
			}
		}

		private void LoadFilters()
		{
			radioEnableDropFilter.Checked  = Settings.Filters.Enabled;
			radioDisableDropFilter.Checked = !radioEnableDropFilter.Checked;
			IsFilterEnabled                = radioEnableDropFilter.Checked;

			int n = 0;

			DragDropDefaultFilters.SetItemCheckState(n++, Helper.BoolToCheckState(Settings.Filters.AllowPK3));
			DragDropDefaultFilters.SetItemCheckState(n++, Helper.BoolToCheckState(Settings.Filters.AllowWAD));
			DragDropDefaultFilters.SetItemCheckState(n++, Helper.BoolToCheckState(Settings.Filters.AllowSOC));
			DragDropDefaultFilters.SetItemCheckState(n++, Helper.BoolToCheckState(Settings.Filters.AllowLua));
			DragDropDefaultFilters.SetItemCheckState(n++, Helper.BoolToCheckState(Settings.Filters.AllowSRB));
			DragDropDefaultFilters.SetItemCheckState(n++, Helper.BoolToCheckState(Settings.Filters.AllowDTA));
			DragDropDefaultFilters.SetItemCheckState(n++, Helper.BoolToCheckState(Settings.Filters.AllowPLR));
			DragDropDefaultFilters.SetItemCheckState(n,   Helper.BoolToCheckState(Settings.Filters.AllowWPN));

			foreach (KeyValuePair<string, bool> d in Settings.Filters.CustomFilters)
			{
				DragDropCustomFilters.Items.Add(d.Key, d.Value);
			}
		}

		#region Event Handlers

		private void buttonOK_Click(object sender, EventArgs e)
		{
			SaveFilters();
			DialogResult = DialogResult.OK;
			Close();
		}

		private void radioEnableDropFilter_CheckedChanged(object sender, EventArgs e)
		{
			groupDefaultFileExtensions.Enabled = radioEnableDropFilter.Checked;
			groupCustomFileExtensions.Enabled  = radioEnableDropFilter.Checked;
		}

		private void buttonAddFilter_Click(object sender, EventArgs e)
		{
			NewFilter = new NewDragDropFilter();
			DialogResult result = NewFilter.ShowDialog();

			if (result == DialogResult.OK)
			{
				foreach (string s in NewFilter.Extensions)
				{
					DragDropCustomFilters.Items.Add(s, true);
				}
			}

			DragDropCustomFilters.Select();
		}

		private void buttonDelFilter_Click(object sender, EventArgs e)
		{
			int selected = DragDropCustomFilters.SelectedIndex;

			DragDropCustomFilters.Items.Remove(DragDropCustomFilters.SelectedItem);
			int itemCount = DragDropCustomFilters.Items.Count;

			if (itemCount < 1)
			{
				return;
			}

			if (selected > itemCount - 1)
			{
				selected = itemCount - 1;
			}

			DragDropCustomFilters.SetSelected(selected, true);
		}

		#endregion
	}
}