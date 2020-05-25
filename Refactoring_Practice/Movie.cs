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

		public double GetCharge(Rental rental)
		{
			double result = 0;
			switch (rental.GetMovie().GetPriceCode())
			{
				case REGULAR:
					result += 2;
					if (rental.GetDaysRented() > 2)
						result += (rental.GetDaysRented() - 2) * 1.5;
					break;
				case NEW_RELEASE:
					result += rental.GetDaysRented() * 3;
					break;
				case CHILDRENS:
					result += 1.5;
					if (rental.GetDaysRented() > 3)
						result += (rental.GetDaysRented() - 3) * 1.5;
					break;
			}

			return result;
		}
	}
}