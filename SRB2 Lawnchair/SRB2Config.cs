using System;
using System.Collections.Generic;
using System.IO;

// TODO: Only set modified flag if the assigned value is different from the existing one.

namespace Lawnchair
{
	class SRB2Config
	{
		private readonly Dictionary<string, List<List<string>>> configFile;

		/// <summary>
		/// Gets the path to the current configuration file.
		/// </summary>
		public string FilePath { get; private set; }

		/// <summary>
		/// Gets a value indicating whether the file has pending modifications.
		/// </summary>
		public bool Modified { get; private set; }

		/// <summary>
		/// Gets a value indicating whether or not the file has been successfully loaded.
		/// </summary>
		public bool Loaded { get; private set; }

		/// <summary>
		/// Instantiates a new SRB2 Configuration File for reading and writing.
		/// </summary>
		/// <param name="filePath">Path to the configuration file to load.</param>
		public SRB2Config(string filePath)
		{
			FilePath = filePath;
			configFile = new Dictionary<string, List<List<string>>>();
			Load();
		}

		/// <summary>
		/// Instantiates a new SRB2 Configuration File for reading and writing.
		/// WARNING: You must call Load() with a valid path before making any changes.
		/// </summary>
		public SRB2Config()
		{
			configFile = new Dictionary<string, List<List<string>>>();
		}

		private bool ContainsKey(string key)
		{
			return configFile.ContainsKey(key);
		}

		private void InitKey(string key)
		{
			if (!ContainsKey(key))
			{
				configFile[key] = new List<List<string>>();
			}
		}

		/// <summary>
		/// Loads the specified configuration file. Changes will be saved to the new path.
		/// </summary>
		/// <param name="filePath">Path to the configuration file to load.</param>
		/// <returns><c>true</c> on success.</returns>
		public bool Load(string filePath)
		{
			FilePath = filePath;
			return Load();
		}

		// TODO: Validate the file by looking for "// SRB2 configuration file."
		/// <summary>
		/// Loads the last configuration, overwriting all stored settings.
		/// </summary>
		/// <returns><c>true</c> on success.</returns>
		public bool Load()
		{
			configFile.Clear();

			if (!File.Exists(FilePath))
			{
				return Loaded = false;
			}

			// TODO: Text stream
			string[] configLines = File.ReadAllLines(FilePath);

			foreach (string s in configLines)
			{
				if (s.StartsWith("//", StringComparison.Ordinal))
				{
					configFile[s] = null;
					continue;
				}

				int i = s.IndexOf(' ');

				if (i < 1)
				{
					configFile[s] = null;
					continue;
				}

				string key    = s.Substring(0, i).Trim();
				string values = s.Substring(i + 1).Trim();

				if (!configFile.ContainsKey(key))
				{
					configFile[key] = new List<List<string>>();
				}

				configFile[key].Add(new List<string>(Helper.GetStringLiterals(values)));
			}

			return Loaded = true;
		}

		/// <summary>
		/// Saves the configuration file to the specified path only if there have been modifications.
		/// </summary>
		/// <param name="filePath">Path to the configuration file to save.</param>
		/// <returns><c>true</c> if modifications were detected and saved.</returns>
		public bool SaveChanged(string filePath)
		{
			FilePath = filePath;
			return SaveChanged();
		}

		/// <summary>
		/// Saves the configuration file only if there have been modifications.
		/// </summary>
		/// <returns><c>true</c> if modifications were detected and saved.</returns>
		public bool SaveChanged()
		{
			if (Modified)
			{
				Save();
			}

			return Modified;
		}

		/// <summary>
		/// Saves the configuration file to the specified path.
		/// </summary>
		/// <param name="filePath">Path to the configuration file to save.</param>
		public void Save(string filePath)
		{
			FilePath = filePath;
			Save();
		}
		/// <summary>
		/// Saves the configuration file to FilePath.
		/// </summary>
		public void Save()
		{
			TextWriter f = File.CreateText(FilePath);

			foreach (KeyValuePair<string, List<List<string>>> entry in configFile)
			{
				if (entry.Value == null)
				{
					f.WriteLine(entry.Key);
					continue;
				}

				foreach (List<string> l in entry.Value)
				{
					f.Write(entry.Key);

					foreach (string s in l)
					{
						f.Write(" \"{0}\"", s);
					}

					f.WriteLine();
				}
			}

			Modified = false;
			f.Close();
		}

		public string GetFirst(string key, int instance = 0)
		{
			List<string> result = Get(key, instance);
			return (result != null && result.Count > 0) ? result[0] : null;
		}

		public List<string> Get(string key, int instance = 0)
		{
			if (!ContainsKey(key))
			{
				return null;
			}

			List<List<string>> entry = configFile[key];

			if (entry == null)
			{
				return null;
			}

			if (instance >= entry.Count)
			{
				throw new IndexOutOfRangeException("You done goofed.");
			}

			return entry[instance];
		}

		public List<List<string>> GetList(string key)
		{
			return ContainsKey(key) ? configFile[key] : null;
		}

		public void Add(string key, string value, int instance = 0)
		{
			AddList(key, new List<string> { value }, instance);
		}

		public void AddList(string key, List<string> value, int instance = 0)
		{
			InitKey(key);
			configFile[key].Add(value);
			Modified = true;
		}

		public void Set(string key, string value, int instance = 0)
		{
			SetList(key, new List<string> { value }, instance);
		}

		public void SetList(string key, List<string> value, int instance = 0)
		{
			if (!ContainsKey(key))
			{
				configFile[key] = new List<List<string>>();
			}

			if (configFile[key].Count == 0)
			{
				configFile[key].Add(new List<string>());
			}

			if (instance >= configFile[key].Count)
			{
				throw new IndexOutOfRangeException("You done goofed.");
			}

			configFile[key][instance] = new List<string>(value);
			Modified = true;
		}
	}
}
