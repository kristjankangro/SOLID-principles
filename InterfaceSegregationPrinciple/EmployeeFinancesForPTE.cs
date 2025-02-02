namespace InterfaceSegregation;

public class EmployeeFinancesForPTE : IEmployeeFinances
{
	public double CalculatePay(Employee emp)
	{
		return emp.TotalHoursWorked * 5;
	}

	public double CalculateRewards(Employee emp)
	{
		return 150;
	}
}