namespace Refactoring_Practice
{
	public class Movie
	{
		private readonly string _title;
		private int _priceCode;
		private IPrice _price;
		public const int REGULAR = 0;
		public const int NEW_RELEASE = 1;
		public const int CHILDRENS = 2;

		public Movie(string title, int priceCode)
		{
			_title = title;
			setPriceCode(priceCode);
		}

		public int getPriceCode()
		{
			return _price.GetPriceCode();
		}

		public void setPriceCode(int priceCode)
		{
			switch (priceCode)
			{
				case REGULAR:
					_price = new RegularPrice();
					break;
				case NEW_RELEASE:
					_price = new NewReleasePrice();
					break;
				case CHILDRENS:
					_price = new ChildrenPrice();
					break;
			}
		}

		public string getTitle()
		{
			return _title;
		}

		public double GetMovieCharge(int daysRented)
		{
			return _price.GetCharge(daysRented);
		}

		public int GetMovieFrequentRenterPoints(int daysRented)
		{
			return _price.GetFrequentRenterPoints(daysRented);

		}
	}

	public class NewReleasePrice : IPrice
	{
		public double GetCharge(int daysRented)
		{
			return daysRented * 3;
		}

		public int GetPriceCode()
		{
			return Movie.NEW_RELEASE;
		}

		public int GetFrequentRenterPoints(int daysRented)
		{
			return daysRented > 1 ? 2 : 1;
		}
	}

	public class ChildrenPrice : IPrice
	{
		public double GetCharge(int daysRented)
		{
			var thisAmount = 1.5;
			if (daysRented > 3)
				thisAmount += (daysRented - 3) * 1.5;
			return thisAmount;
		}

		public int GetPriceCode()
		{
			return Movie.CHILDRENS;
		}

		public int GetFrequentRenterPoints(int daysRented)
		{
			return 1;
		}
	}

	public class RegularPrice : IPrice
	{
		public double GetCharge(int daysRented)
		{
			double thisAmount = 2;
			if (daysRented > 2)
				thisAmount += (daysRented - 2) * 1.5;

			return thisAmount;
		}

		public int GetPriceCode()
		{
			return Movie.REGULAR;
		}

		public int GetFrequentRenterPoints(int daysRented)
		{
			return 1;
		}
	}

	internal interface IPrice
	{
		double GetCharge(int daysRented);
		int GetPriceCode();
		int GetFrequentRenterPoints(int daysRented);
	}
}