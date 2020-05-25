using System;

namespace Refactoring_Practice
{
	public class Movie
	{
		private readonly string _title;
		private IPrice _price;
		public const int REGULAR = 0;
		public const int NEW_RELEASE = 1;
		public const int CHILDRENS = 2;

		public Movie(string title, int priceCode)
		{
			_title = title;
			SetPriceCode(priceCode);
		}

		public int GetPriceCode()
		{
			return _price.GetPriceCode();
		}

		public void SetPriceCode(int priceCode)
		{
			switch (priceCode)
			{
				case REGULAR:
					_price = new RegularPrice();
					break;
				case CHILDRENS:
					_price = new ChildrenPrice();
					break;
				case NEW_RELEASE:
					_price = new NewReleasePrice();
					break;
				default:
					throw new Exception();
			}
		}

		public string GetTitle()
		{
			return _title;
		}

		public double GetCharge(int daysRented)
		{
			return _price.GetCharge(daysRented);
		}

		public int GetFrequentRenterPoints(int daysRented)
		{
			return _price.GetFrequentRenterPoints(daysRented);
		}
	}
}
