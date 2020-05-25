namespace Refactoring_Practice
{
	public class Rental
	{
		private readonly int _daysRented;
		private readonly Movie _movie;

		public Rental(Movie movie, int daysRented)
		{
			_movie = movie;
			_daysRented = daysRented;
		}

		public int GetFrequentRenterPoints()
		{
			return _movie.GetMovieFrequentRenterPoints(_daysRented);
		}

		public Movie GetMovie()
		{
			return _movie;
		}

		public double GetCharge()
		{
			return _movie.GetMovieCharge(_daysRented);
		}
	}
}