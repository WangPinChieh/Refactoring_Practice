﻿using System.Collections.Generic;

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
				double thisAmount = 0;
				//determine amounts for each line
				switch (rental.getMovie().getPriceCode())
				{
					case Movie.REGULAR:
						thisAmount += 2;
						if (rental.getDaysRented() > 2)
							thisAmount += (rental.getDaysRented() - 2) * 1.5;
						break;
					case Movie.NEW_RELEASE:
						thisAmount += rental.getDaysRented() * 3;
						break;
					case Movie.CHILDRENS:
						thisAmount += 1.5;
						if (rental.getDaysRented() > 3)
							thisAmount += (rental.getDaysRented() - 3) * 1.5;
						break;
				}

				// add frequent renter points
				frequentRenterPoints++;
				// add bonus for a two day new release rental
				if ((rental.getMovie().getPriceCode() == Movie.NEW_RELEASE)
				    &&
				    rental.getDaysRented() > 1) frequentRenterPoints++;
				//show figures for this rental
				result += "\t" + rental.getMovie().getTitle() + "\t" +
				          thisAmount + "\n";

				totalAmount += thisAmount;
			}
			//add footer lines
			result += "Amount owed is " + totalAmount + "\n";
			result += "You earned " + frequentRenterPoints + " frequent renter points";
			return result;
		}
	}
}