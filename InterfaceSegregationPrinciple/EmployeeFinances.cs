namespace InterfaceSegregation;

public interface IEmployeeRewards
{
	double CalculateRewards(Employee emp);
}

public interface IEmployeeFinances : IEmployeeRewards
{
	double CalculatePay(Employee emp);
}

public class EmployeeRewards : IEmployeeRewards
{
	public virtual double CalculateRewards(Employee emp)
	{
		return 100;
	}
}

public class EmployeeFinances : IEmployeeFinances
{
	public virtual double CalculatePay(Employee emp)
	{
		return 10;
	}

	public virtual double CalculateRewards(Employee emp)
	{
		return 100;
	}
}


public class EmployeeFinancesForFTE : EmployeeFinances
{
	public override double CalculatePay(Employee emp)
	{
		return emp.TotalHoursWorked * 10;
	}

	public override double CalculateRewards(Employee emp)
	{
		return 200;
	}
}

public class EmployeeFinancesForPTE : EmployeeFinances
{
	public override double CalculatePay(Employee emp)
	{
		return emp.TotalHoursWorked * 5;
	}

	public override double CalculateRewards(Employee emp)
	{
		return 150;
	}
}

public class EmployeeFinancesForContractor : EmployeeRewards
{
	public override double CalculateRewards(Employee emp)
	{
		return 120;
	}
}