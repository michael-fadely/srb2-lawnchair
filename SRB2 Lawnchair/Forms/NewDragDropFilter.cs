using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lawnchair.Forms
{
	public partial class NewDragDropFilter : Form
	{
		public readonly List<string> Extensions;

		public NewDragDropFilter()
		{
			InitializeComponent();
			Extensions = new List<string>();
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			string[] newFilters = textBox.Text.Split(' ');

			foreach (string s in newFilters)
			{
				if (!s.StartsWith(".", StringComparison.Ordinal))
				{
					Extensions.Add("." + s);
				}
				else
				{
					Extensions.Add(s);
				}
			}

			DialogResult = DialogResult.OK;
			Close();
		}

		private void NewDragDropFilter_Shown(object sender, EventArgs e)
		{
			Extensions.Clear();
			textBox.Clear();
			textBox.Select();
		}

		private void textBox_TextChanged(object sender, EventArgs e)
		{
			buttonOK.Enabled = (textBox.Text.Length > 1);
		}
	}
}