using System;

namespace Refactoring_Practice
{
	class Program
	{
		static void Main(string[] args)
		{
			var customer = new Customer("Jay");
			customer.addRental(new Rental(new Movie("Happy Friday", Movie.REGULAR), 20));
			customer.addRental(new Rental(new Movie("Happy Friday", Movie.NEW_RELEASE), 20));

			Console.WriteLine(customer.GetStatement());
			Console.ReadLine();
		}
	}
}

