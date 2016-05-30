using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lawnchair.Forms
{
	public partial class NewDragDropFilter : Form
	{
		public readonly List<string> extensions;

		public NewDragDropFilter()
		{
			InitializeComponent();
			extensions = new List<string>();
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			string[] newFilters = textBox.Text.Split(' ');

			foreach (string s in newFilters)
			{
				if (!s.StartsWith("."))
					extensions.Add("." + s);
				else
					extensions.Add(s);
			}

			DialogResult = DialogResult.OK;
			Close();
		}

		private void NewDragDropFilter_Shown(object sender, EventArgs e)
		{
			extensions.Clear();
			textBox.Clear();
			textBox.Select();
		}

		private void textBox_TextChanged(object sender, EventArgs e)
		{
			buttonOK.Enabled = (textBox.Text.Length > 1);
		}
	}
}