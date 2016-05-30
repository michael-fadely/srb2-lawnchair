using System;
using System.Windows.Forms;

namespace Lawnchair.Forms
{
	public partial class Settings : Form
	{
		private LawnchairSettings settings;
		public Settings(LawnchairSettings settings)
		{
			this.settings = settings;
			InitializeComponent();
		}

		private void Settings_Load(object sender, EventArgs e)
		{
			comboGameVersion.SelectedIndex = (int)settings.Launcher.GameVersion;
			checkMinimizeOnLaunch.Checked = settings.Launcher.MinimizeOnLaunch;
			textConfigPath.Text = settings.Game.ConfigPath;
			textDConfigPath.Text = settings.Game.DConfigPath;
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;

			settings.Launcher.GameVersion = (SRB2Version)comboGameVersion.SelectedIndex;
			settings.Launcher.MinimizeOnLaunch = checkMinimizeOnLaunch.Checked;
			settings.Game.ConfigPath = textConfigPath.Text;
			settings.Game.DConfigPath = textDConfigPath.Text;

			Close();
		}

		private void BrowseConfig(TextBox textBox)
		{
			openConfigDialog.FileName = textBox.Text;

			if (openConfigDialog.ShowDialog() == DialogResult.OK)
				textBox.Text = Helper.StripDirectory(openConfigDialog.FileName, MainWindow.workingDirectory);
		}

		private void buttonConfigBrowse_Click(object sender, EventArgs e)
		{
			BrowseConfig(textConfigPath);
		}

		private void buttonDConfigBrowse_Click(object sender, EventArgs e)
		{
			BrowseConfig(textDConfigPath);
		}
	}
}