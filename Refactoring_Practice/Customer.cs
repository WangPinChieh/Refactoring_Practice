﻿using System.Collections.Generic;
using System.Linq;

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
			var result = "Rental Record for " + getName() + "\n";

			result = _rentals.Aggregate(result, (current, rental) => current + ("\t" + rental.GetMovie().GetTitle() + "\t" + rental.GetMovie().GetCharge(rental.GetDaysRented()) + "\n"));

			result += "Amount owed is " + GetTotalAmount() + "\n";

			result += "You earned " + GetFrequentRenterPoints() + " frequent renter points";

			return result;
		}
		public string GeHtmltStatement()
		{
			var result = "<h1>Rental Record for <em>" + getName() + "</em></h1>\n";

			result = _rentals.Aggregate(result, (current, rental) => current + (rental.GetMovie().GetTitle() + " : " + rental.GetMovie().GetCharge(rental.GetDaysRented()) + "<br/>\n"));

			result += "<p>Amount owed is <em>" + GetTotalAmount() + "</em></p>\n";

			result += "You earned " + GetFrequentRenterPoints() + " frequent renter points";

			return result;
		}

		private decimal GetFrequentRenterPoints()
		{
			return _rentals.Sum(rental => rental.GetFrequentRenterPoints());
		}

		private double GetTotalAmount()
		{
			return _rentals.Sum(rental => rental.GetCharge());
		}
	}
}