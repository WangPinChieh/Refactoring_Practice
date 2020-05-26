namespace Refactoring_Practice
{
	internal interface IPrice
	{
		int GetPriceCode();
		double GetCharge(int daysRented);
		int GetFrequentRenterPoints(int daysRented);
	}
}