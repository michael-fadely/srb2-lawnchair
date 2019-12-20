using System;
using System.Windows.Forms;

namespace Lawnchair.Forms
{
	partial class AboutWindow : Form
	{
		private ushort EasterEgg;

		public AboutWindow()
		{
			InitializeComponent();
		}

		private void AboutWindow_Load(object sender, EventArgs e)
		{
			EasterEgg             = 0;
			Text                  = $"About {AssemblyInfo.Title}";
			labelProductName.Text = AssemblyInfo.Product;
			labelVersion.Text     = $"Version {AssemblyInfo.Version}";
			labelCopyright.Text   = AssemblyInfo.Copyright;
			labelCompanyName.Text = AssemblyInfo.Company;
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void logoPictureBox_Click(object sender, EventArgs e)
		{
			EasterEgg %= 6;

			switch (EasterEgg)
			{
				case 0:
					MessageBox.Show("Ow! Cut that out!", "Poke-a-chu!",
					                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					break;

				case 1:
					MessageBox.Show("Watch where you put that mouse...", "Peek-a-poke!",
					                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					break;

				case 2:
					MessageBox.Show("HAHAHA! That tickles!", "Coohie-coo!",
					                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					break;

				case 3:
					MessageBox.Show("WOW! That pointer is COLD!", "YEOW!",
					                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					break;

				case 4:
					if (MessageBox.Show("Are you at least gonna buy me a drink first?", "Nervous?",
					                    MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
					{
						MessageBox.Show("Cool! Let's play!", @"\/\/00+!",
						                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					}
					else
					{
						MessageBox.Show("Sorry, not interested then...", "Hmph!",
						                MessageBoxButtons.OK, MessageBoxIcon.Stop);
					}

					break;

				case 5:
					MessageBox.Show("HEY! Pervert!", "EEK!",
					                MessageBoxButtons.OK, MessageBoxIcon.Stop);
					break;
			}

			EasterEgg++;
		}
	}
}