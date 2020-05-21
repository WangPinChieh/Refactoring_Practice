﻿namespace Refactoring_Practice
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

		public int getPriceCode()
		{
			return _priceCode;
		}

		public void setPriceCode(int priceCode)
		{
			_priceCode = priceCode;
		}

		public string getTitle()
		{
			return _title;
		}
	}
}