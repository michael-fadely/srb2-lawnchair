using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Lawnchair.Forms;
using System.Text;

namespace Lawnchair
{
	public enum SRB2Version
	{
		v21x,
		v20x,
		v109x,
		v108x,
		count
	}

	internal static class Helper
	{
		public static short LetterPosition(char letter)
		{
			return (short)(char.ToLower(letter) - 'a');
		}

		public static char IntToLetter(int letter)
		{
			return (char)('A' + letter);
		}

		public static int ExMapToInt(string text)
		{
			short p = 0;
			short q = 10;
			int result = 0;

			if (text.Length == 2)
			{
				char x = text[0];
				char y = text[1];

				if (char.IsLetter(x))
					p = LetterPosition(x);
				else if (char.IsNumber(x))
					p = (short)char.GetNumericValue(x);

				if (char.IsLetter(y))
					q += LetterPosition(y);
				else if (char.IsNumber(y))
					q = (short)char.GetNumericValue(y);

				if (!char.IsLetter(x) && !char.IsLetter(y))
					return Convert.ToInt16(text);

				result = ((36 * p + q) + 100);
			}
			else if (text.Length == 1 && char.IsNumber(text[0]) && Convert.ToInt32(text) < 10)
				result = Convert.ToInt32(text);

			return result;
		}

		public static string IntToExMap(int num)
		{
			string result;

			if (num > 99)
			{
				short x = (short)(num - 100);
				short p = (short)(x / 36);
				short q = (short)(x - (36 * p));
				string a = IntToLetter(p).ToString();
				string b = q < 10 ? q.ToString() : IntToLetter((q - 10)).ToString();

				result = a + b;
			}
			else
			{
				if (num < 10)
					result = "0" + num;
				else
					result = num.ToString();
			}

			return result;
		}

		public static bool checkMapNum(string mapNum)
		{
			bool result = false;

			switch (mapNum.Length)
			{
				case 0:
					MessageBox.Show("You didn't specify a map number!", "Map number error",
						MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					result = true;
					break;

				case 1:
					if (!char.IsLetter(mapNum[0]) && Convert.ToInt32(mapNum) < 10)
					{
						if (Convert.ToInt32(mapNum) < 1)
						{
							MessageBox.Show("The map number you specified is invalid; the map number cannot be less than 1.",
								"Map number error",
								MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							result = true;
						}
					}
					if (char.IsLetter(mapNum[0]))
					{
						MessageBox.Show("The map number you specified was less than two characters and is not a number.",
							"Map number error",
							MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						result = true;
					}
					break;

				case 2:
					if (!char.IsLetter(mapNum[0]) && char.IsLetter(mapNum[1]))
					{
						MessageBox.Show("Map numbers that begin with a number may only end with numbers.",
							"Map number error",
							MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						result = true;
					}
					break;

				default:
					if (mapNum.Length >= 3)
					{
						int n;
						bool isNum = int.TryParse(mapNum, out n);

						if (!isNum)
						{
							MessageBox.Show("The map number you specified is longer than 2 characters but is not a number.",
								"Map number error",
								MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						}

						result = !isNum;
					}
					break;
			}

			return result;
		}

		public static string WarpHandler(string mapNum, string gametype, SRB2Version gameVersion)
		{
			StringBuilder result = new StringBuilder("-warp " + mapNum + " -gametype ");

			// TODO: Replace this kind of stuff throughout the project with a dictionary maybe?
			switch (gametype)
			{
				case "Co-op":
					result.Append("0");
					break;

				case "Competition":
					result.Append(gameVersion >= SRB2Version.v21x ? "1" : "0");
					break;

				case "Race":
					result.Append("2");
					break;

				case "Match":
					result.Append(gameVersion >= SRB2Version.v21x ? "3" : "1");
					break;

				case "Team Match":
					if (gameVersion >= SRB2Version.v21x)
						result.Append("4");
					break;

				case "Tag":
					result.Append(gameVersion >= SRB2Version.v21x ? "5" : "3");
					break;

				case "Hide and Seek":
					if (gameVersion >= SRB2Version.v21x)
						result.Append("6");
					break;

				case "Capture the Flag":
					result.Append(gameVersion >= SRB2Version.v21x ? "7" : "4");
					break;

				default:
					result.Append("0");
					break;
			}

			return result.ToString();
		}

		public static string StripDirectory(string path, string workdir)
		{
			// TODO: Use Substring instead of Replace for safety reasons
			return path.Replace(workdir + Path.DirectorySeparatorChar, "");
		}

		public static List<string> FileStrings(DirectoryInfo dir, ref List<string> list)
		{
			List<string> paths = new List<string>();

			foreach (FileInfo info in dir.GetFiles())
			{
				if (isCommonFile(info.Extension, ref list))
					paths.Add(info.FullName);
			}

			foreach (DirectoryInfo info in dir.GetDirectories())
			{
				paths.AddRange(FileStrings(info, ref list));
			}

			return paths;
		}

		public static bool isCommonFile(string fileExtension, ref List<string> list)
		{
			return (!DragDropFilter.isFilterEnabled || list.Contains(fileExtension.ToLower()));
		}

		public static List<string> GetStringLiterals(string str, bool allowEscape = true, char escapeDelim = '\\')
		{
			List<string> result = new List<string>();
			string text = string.Empty;
			bool quote = false;
			bool escape = false;

			foreach (char c in str)
			{
				if (!escape)
				{
					if (allowEscape && c == escapeDelim)
					{
						escape = true;
						continue;
					}
					if (c == '"')
					{
						quote = !quote;
						continue;
					}
				}

				if (escape || quote)
				{
					text += c;
				}
				else if (!string.IsNullOrEmpty(text))
				{
					result.Add(text);
					text = string.Empty;
				}

				escape = false;
			}

			if (!string.IsNullOrEmpty(text))
				result.Add(text);

			return result;
		}

		public static CheckState BoolToCheckState(bool value)
		{
			return (value) ? CheckState.Checked : CheckState.Unchecked;
		}

		public static void GametypeHandler(ref ComboBox combo, SRB2Version version)
		{
			combo.BeginUpdate();
			combo.Items.Clear();

			if (version == SRB2Version.v21x)
			{
				combo.Items.AddRange(
					new object[]
					{
						"Co-op",
						"Competition",
						"Race",
						"Match",
						"Team Match",
						"Tag",
						"Hide and Seek",
						"Capture the Flag"
					}
					);
			}
			else
			{
				combo.Items.AddRange(
					new object[]
					{
						"Co-op",
						"Match",
						"Race",
						"Tag",
						"Capture the Flag"
						//"Team Match",
						//"Classic Race",
						//"Hide and Seek"
					}
					);
			}

			combo.SelectedIndex = 0;
			combo.EndUpdate();
		}

		public static void textAutoSelectText(TextBoxBase sender)
		{
			sender.SelectAll();
		}

		/*
		public static int VersionToIndex(SRB2Version version)
		{
			int result = (int)version;
			return ((int)SRB2Version.count - 1) - result;
		}
		*/
	}
}