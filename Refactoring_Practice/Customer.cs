using System.Collections.Generic;

namespace Refactoring_Practice
{
	public class Customer
	{
		private readonly string _name;
		private readonly List<Rental> _rentals = new List<Rental>();

		public Customer(string name)
		{
			_name = name;
		}

		public void addRental(Rental rental)
		{
			_rentals.Add(rental);
		}

		public string getName()
		{
			return _name;
		}

		public string GetStatement()
		{
			double totalAmount = 0;
			var frequentRenterPoints = 0;
			var result = "Rental Record for " + getName() + "\n";
			foreach (var rental in _rentals)
			{
				//determine amounts for each line

				// add frequent renter points
				frequentRenterPoints += rental.GetFrequentRenterPoints();

				//show figures for this rental
				result += "\t" + rental.getMovie().getTitle() + "\t" +
				          rental.GetCharge() + "\n";

				totalAmount += rental.GetCharge();
			}
			//add footer lines
			result += "Amount owed is " + totalAmount + "\n";
			result += "You earned " + frequentRenterPoints + " frequent renter points";
			return result;
		}
	}
}