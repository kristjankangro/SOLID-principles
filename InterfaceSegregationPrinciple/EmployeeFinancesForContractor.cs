namespace InterfaceSegregation;

public class EmployeeFinancesForContractor : IEmployeeRewards
{
	public double CalculateRewards(Employee emp)
	{
		return 120;
	}
}