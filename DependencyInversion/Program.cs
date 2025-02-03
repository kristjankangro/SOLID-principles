namespace DependencyInversion;
using Unity;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        IUnityContainer container = new UnityContainer();
        container.RegisterType<ILogger, FileLogger>();
        container.RegisterType<ILogger, DatabaseLogger>();
        Employee employee = container.Resolve<Employee>();
        employee.Save(employee);

        // old after unity DI
        // Employee empFTE = new Employee(new FileLogger()) { EmployeeType = EmpType.FullTime.ToString(), TotalHoursWorked = 10 };
        // Employee empPTE = new Employee(new FileLogger()) { EmployeeType = EmpType.PartTime.ToString(), TotalHoursWorked = 10 };
        // Employee empContractor = new Employee(new FileLogger()) { EmployeeType = EmpType.Contractor.ToString(), TotalHoursWorked = 10 };
        //
        // empFTE.Save(empFTE);
        //
        // Console.Read();
    } 
}