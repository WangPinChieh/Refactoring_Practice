namespace Refactoring_Practice
{
	public class Rental
	{
		private readonly Movie _movie;
		private readonly int _daysRented;

		public Rental(Movie movie, int daysRented)
		{
			_movie = movie;
			_daysRented = daysRented;
		}

		public int getDaysRented()
		{
			return _daysRented;
		}

		public Movie getMovie()
		{
			return _movie;
		}

		public double GetCharge()
		{
			return _movie.GetMovieCharge(_daysRented);
		}

		public int GetFrequentRenterPoints()
		{
			return _movie.GetMovieFrequentRenterPoints(_daysRented);
		}
	}
}