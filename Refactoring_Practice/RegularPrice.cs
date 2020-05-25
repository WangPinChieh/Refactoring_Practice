namespace Refactoring_Practice
{
	public class RegularPrice : IPrice
	{
		public int GetPriceCode()
		{
			return Movie.Regular;
		}

		public double GetCharge(int daysRented)
		{
			double thisAmount = 2;
			if (daysRented > 2)
				thisAmount += (daysRented - 2) * 1.5;
			return thisAmount;
		}

		public int GetFrequentRenterPoints(int daysRented)
		{
			return 1;
		}
	}
}