using System;

namespace TDD_Taxi
{
	public class Calculation
	{
		public static int GetPrice(int distance, int waiting)
		{
			double price = 6;
			price += Math.Min(6, Math.Max(distance - 2, 0)) * 0.8;
			price += Math.Max(distance - 8, 0) * 0.8 * 1.5;
			price += waiting * 0.25;
			return (int)Math.Round(price, MidpointRounding.AwayFromZero);
		}
	}
}