using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lawnchair.Forms
{
	public partial class DragDropFilter : Form
	{
		public static bool IsFilterEnabled;

		private NewDragDropFilter NewFilter;
		public  LawnchairSettings Settings { get; private set; }

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

			Settings.Filters.AllowWAD = DragDropDefaultFilters.GetItemChecked(0);
			Settings.Filters.AllowSOC = DragDropDefaultFilters.GetItemChecked(1);
			Settings.Filters.AllowLua = DragDropDefaultFilters.GetItemChecked(2);
			Settings.Filters.AllowSRB = DragDropDefaultFilters.GetItemChecked(3);
			Settings.Filters.AllowDTA = DragDropDefaultFilters.GetItemChecked(4);
			Settings.Filters.AllowPLR = DragDropDefaultFilters.GetItemChecked(5);
			Settings.Filters.AllowWPN = DragDropDefaultFilters.GetItemChecked(6);

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

			DragDropDefaultFilters.SetItemCheckState(0, Helper.BoolToCheckState(Settings.Filters.AllowWAD));
			DragDropDefaultFilters.SetItemCheckState(1, Helper.BoolToCheckState(Settings.Filters.AllowSOC));
			DragDropDefaultFilters.SetItemCheckState(2, Helper.BoolToCheckState(Settings.Filters.AllowLua));
			DragDropDefaultFilters.SetItemCheckState(3, Helper.BoolToCheckState(Settings.Filters.AllowSRB));
			DragDropDefaultFilters.SetItemCheckState(4, Helper.BoolToCheckState(Settings.Filters.AllowDTA));
			DragDropDefaultFilters.SetItemCheckState(5, Helper.BoolToCheckState(Settings.Filters.AllowPLR));
			DragDropDefaultFilters.SetItemCheckState(6, Helper.BoolToCheckState(Settings.Filters.AllowWPN));

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

			if (itemCount > 0)
			{
				if (selected > itemCount - 1)
				{
					selected = itemCount - 1;
				}

				DragDropCustomFilters.SetSelected(selected, true);
			}
		}

		#endregion
	}
}