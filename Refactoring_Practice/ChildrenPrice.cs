﻿namespace Refactoring_Practice
{
	public class ChildrenPrice : IPrice
	{
		public int GetPriceCode()
		{
			return Movie.Children;
		}

		public double GetCharge(int daysRented)
		{
			var result = 1.5;
			if (daysRented > 3)
				result += (daysRented - 3) * 1.5;
			return result;
		}

		public int GetFrequentRenterPoints(int daysRented)
		{
			return 1;
		}
	}
}