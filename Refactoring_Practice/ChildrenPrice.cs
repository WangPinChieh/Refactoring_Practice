namespace Refactoring_Practice
{
	public class ChildrenPrice : IPrice
	{
		public int GetPriceCode()
		{
			return Movie.Children;
		}

		public double GetCharge(int daysRented)
		{
			var thisAmount = 1.5;
			if (daysRented > 3)
				thisAmount += (daysRented - 3) * 1.5;
			return thisAmount;
		}

		public int GetFrequentRenterPoints(int daysRented)
		{
			return 1;
		}
	}
}