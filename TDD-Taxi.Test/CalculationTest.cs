using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD_Taxi.Test
{
	[TestClass]
	public class CalculationTest
	{
		[TestMethod]
		public void TestCalculation_Lessthan_2km_Without_Wait()
		{
			Assert.AreEqual(6, Calculation.GetPrice(1, 0));
		}

		[TestMethod]
		public void TestCalculation_Lessthan_8km_Without_Wait()
		{
			Assert.AreEqual(7, Calculation.GetPrice(3, 0));
		}

		[TestMethod]
		public void TestCalculation_Morethan_8km_Without_Wait()
		{
			Assert.AreEqual(13, Calculation.GetPrice(10, 0));
		}

		[TestMethod]
		public void TestCalculation_With_Wait()
		{
			Assert.AreEqual(7, Calculation.GetPrice(1, 2));
		}
	}
}
