namespace Refactoring_Practice
{
	public class NewReleasePrice : IPrice
	{
		public int GetPriceCode()
		{
			return Movie.NewRelease;
		}

		public double GetCharge(int daysRented)
		{
			var thisAmount = daysRented * 3;
			return thisAmount;
		}

		public int GetFrequentRenterPoints(int daysRented)
		{
			return daysRented > 1 ? 2 : 1;
		}
	}
}