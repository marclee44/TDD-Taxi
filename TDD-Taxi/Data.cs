using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace TDD_Taxi
{
	public class Data
	{
		public Data(string[] datas)
		{
			Datas = new List<Tuple<int, int>>();
			foreach (string each in datas)
			{
				var data = Regex.Matches(each, @"[\d]+");
				Datas.Add(new Tuple<int, int>(Convert.ToInt32(data[0].Value), Convert.ToInt32(data[1].Value)));
			}
		}

		public Tuple<int, int> GetCurrent()
		{
			var current = Datas.FirstOrDefault();
			Datas.RemoveAt(0);
			return current;
		}

		private List<Tuple<int, int>> Datas;
	}
}