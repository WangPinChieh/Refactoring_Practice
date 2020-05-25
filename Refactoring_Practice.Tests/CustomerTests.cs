using NUnit.Framework;

namespace Refactoring_Practice.Tests
{
	[TestFixture]
	public class CustomerTests
	{
		private Customer _customer;

		[Test]
		public void Statement_RentNewReleasedMovie20Days()
		{
			GivenCustomer();

			RentAMovie(Movie.NEW_RELEASE, 20);

			var expected = "Rental Record for Jay\n\tHappy Friday\t60\nAmount owed is 60\nYou earned 2 frequent renter points";

			Assert.AreEqual(expected, _customer.GetStatement());
		}

		[Test]
		public void Statement_RentRegularMovie20Days()
		{
			GivenCustomer();

			RentAMovie(Movie.REGULAR, 20);

			var expected = "Rental Record for Jay\n\tHappy Friday\t29\nAmount owed is 29\nYou earned 1 frequent renter points";

			Assert.AreEqual(expected, _customer.GetStatement());
		}

		[Test]
		public void Statement_RentChildrenMovie20Days()
		{
			GivenCustomer();

			RentAMovie(Movie.CHILDRENS, 20);

			var expected = "Rental Record for Jay\n\tHappy Friday\t27\nAmount owed is 27\nYou earned 1 frequent renter points";

			Assert.AreEqual(expected, _customer.GetStatement());

		}
		private void RentAMovie(int movieTypeCode, int daysRented)
		{
			_customer.addRental(new Rental(new Movie("Happy Friday", movieTypeCode), daysRented));
		}

		private void GivenCustomer()
		{
			_customer = new Customer("Jay");
		}
	}
}