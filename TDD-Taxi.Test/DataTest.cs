using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD_Taxi.Test
{
	[TestClass]
	public class DataTest
	{
		[TestMethod]
		public void Test_Data()
		{
			string[] datas = new string[]
			{
				"1公里,等待0分钟",
				"3公里,等待0分钟",
				"10公里,等待0分钟",
				"2公里,等待3分钟"
			};
			Data data = new Data(datas);
			var first = data.GetCurrent();
			Assert.AreEqual(1, first.Item1);
			Assert.AreEqual(0, first.Item2);
			data.GetCurrent();
			data.GetCurrent();
			var last = data.GetCurrent();
			Assert.AreEqual(2, last.Item1);
			Assert.AreEqual(3, last.Item2);
		}
	}
}
