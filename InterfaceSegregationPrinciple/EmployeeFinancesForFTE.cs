namespace InterfaceSegregation;

public class EmployeeFinancesForFTE : IEmployeeFinances
{
	public double CalculatePay(Employee emp)
	{
		return emp.TotalHoursWorked * 10;
	}

	public double CalculateRewards(Employee emp)
	{
		return 200;
	}
}