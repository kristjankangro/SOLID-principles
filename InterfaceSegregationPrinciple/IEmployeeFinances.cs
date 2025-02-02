namespace InterfaceSegregation;

public interface IEmployeeFinances : IEmployeeRewards
{
	double CalculatePay(Employee emp);
	
}