﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EssentialsPlus
{
	public class Config
	{
		public int BackPointHistory = 10;
		public bool EnableBackInPvp = true;

		public string MySqlHost = "";
		public string MySqlDbName = "";
		public string MySqlUsername = "";
		public string MySqlPassword = "";

		public void Write(string path)
		{
			File.WriteAllText(path, JsonConvert.SerializeObject(this, Formatting.Indented));
		}

		public static Config Read(string path)
		{
			return File.Exists(path) ? JsonConvert.DeserializeObject<Config>(File.ReadAllText(path)) : new Config();
		}
	}
}