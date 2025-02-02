namespace InterfaceSegregation;

public interface IEmployeeStock : IEmployeeFinances
{
	double CalculateStock(Employee emp);
}