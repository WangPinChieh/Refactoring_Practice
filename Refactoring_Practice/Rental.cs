namespace Refactoring_Practice
{
	public class Rental
	{
		private readonly int _daysRented;

		public Rental(Movie movie, int daysRented)
		{
			Movie = movie;
			_daysRented = daysRented;
		}

		public Movie Movie { get; }

		public int GetDaysRented()
		{
			return _daysRented;
		}

		public Movie GetMovie()
		{
			return Movie;
		}

		public int GetFrequentRenterPoints()
		{
			var frequentRenterPoints = 0;
			frequentRenterPoints++;

			if ((GetMovie().GetPriceCode() == Movie.NEW_RELEASE)
			    && GetDaysRented() > 1) frequentRenterPoints++;
			return frequentRenterPoints;
		}
	}
}