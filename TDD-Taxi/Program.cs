using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Taxi
{
	class Program
	{
		static void Main(string[] args)
		{
			var inputs = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "Data", args[0]));
			Data data = new Data(inputs);
			string receipt = string.Empty;
			for (int i = 0; i < inputs.Length; i++)
			{
				var current = data.GetCurrent();
				receipt += string.Format("收费{0}元{1}", Calculation.GetPrice(current.Item1, current.Item2), "\n");
			}
			receipt = receipt.Substring(0, receipt.Length - 1);
			Console.WriteLine(receipt);
			Console.WriteLine("按任意键退出。。。");
			Console.ReadKey();
		}
	}
}
