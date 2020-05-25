namespace Refactoring_Practice
{
	public interface IPrice
	{
		int GetPriceCode();
		double GetCharge(int daysRented);
	}
}