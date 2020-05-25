using System;

namespace Refactoring_Practice
{
	public class Movie
	{
		private readonly string _title;
		private IPrice _price;
		public const int Regular = 0;
		public const int NewRelease = 1;
		public const int Children = 2;

		public Movie(string title, int priceCode)
		{
			_title = title;
			SetPriceCode(priceCode);
		}

		public void SetPriceCode(int priceCode)
		{
			switch (priceCode)
			{
				case Regular:
					_price = new RegularPrice();
					break;
				case Children:
					_price = new ChildrenPrice();
					break;
				case NewRelease:
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

		public double GetMovieCharge(int daysRented)
		{
			return _price.GetCharge(daysRented);
		}

		public int GetMovieFrequentRenterPoints(int daysRented)
		{
			return _price.GetFrequentRenterPoints(daysRented);
		}
	}
}