namespace InterfaceSegregation;

public class EmployeeFinancesForCLevel : IEmployeeStock
{
	public double CalculateRewards(Employee emp)
	{
		return 50;
	}

	public double CalculatePay(Employee emp)
	{
		return 50;
	}

	public double CalculateStock(Employee emp)
	{
		return 50;
	}
}