namespace Refactoring_Practice
{
	public class RegularPrice : IPrice
	{
		public int GetPriceCode()
		{
			return Movie.REGULAR;
		}

		public double GetCharge(int daysRented)
		{
			double result = 2;
			if (daysRented > 2)
				result += (daysRented - 2) * 1.5;

			return result;
		}

		public int GetFrequentRenterPoints(int daysRented)
		{
			return 1;
		}
	}
}