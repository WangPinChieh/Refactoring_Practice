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

		public int GetFrequentRenterPoints(int getDaysRented)
		{
			var frequentRenterPoints = 0;
			frequentRenterPoints++;

			if ((GetPriceCode() == NEW_RELEASE)
			    && getDaysRented > 1) frequentRenterPoints++;

			return frequentRenterPoints;
		}
	}

	public class ChildrenPrice : IPrice
	{
		public int GetPriceCode()
		{
			return Movie.CHILDRENS;
		}

		public double GetCharge(int daysRented)
		{
			var result = 1.5;
			if (daysRented > 3)
				result += (daysRented - 3) * 1.5;

			return result;
		}
	}

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
	}

	public interface IPrice
	{
		int GetPriceCode();
		double GetCharge(int daysRented);
	}
}
