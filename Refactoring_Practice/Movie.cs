namespace Refactoring_Practice
{
	public class Movie
	{
		private readonly string _title;
		private int _priceCode;
		public const int REGULAR = 0;
		public const int NEW_RELEASE = 1;
		public const int CHILDRENS = 2;

		public Movie(string title, int priceCode)
		{
			_title = title;
			_priceCode = priceCode;
		}

		public int GetPriceCode()
		{
			return _priceCode;
		}

		public void SetPriceCode(int priceCode)
		{
			_priceCode = priceCode;
		}

		public string GetTitle()
		{
			return _title;
		}

		public double GetCharge(int daysRented)
		{
			double result = 0;
			switch (GetPriceCode())
			{
				case REGULAR:
					result += 2;
					if (daysRented > 2)
						result += (daysRented - 2) * 1.5;
					break;
				case NEW_RELEASE:
					result += daysRented * 3;
					break;
				case CHILDRENS:
					result += 1.5;
					if (daysRented > 3)
						result += (daysRented - 3) * 1.5;
					break;
			}

			return result;
		}
	}
}