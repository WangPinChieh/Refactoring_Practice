namespace Refactoring_Practice
{
	public class NewReleasePrice : IPrice
	{
		public int GetPriceCode()
		{
			return Movie.NEW_RELEASE;
		}

		public double GetCharge(int daysRented)
		{
			return daysRented * 3;
		}
	}
}