using System;

namespace InterfaceSegregation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Employee empFTE = new Employee() { EmployeeType = empType.FullTime.ToString(), TotalHoursWorked = 10 };
            Employee empPTE = new Employee() { EmployeeType = empType.PartTime.ToString(), TotalHoursWorked = 10 };
            Employee empContractor = new Employee { EmployeeType = empType.Contractor.ToString(), TotalHoursWorked = 10 };

            IEmployeeFinances employeeFinances = new EmployeeFinancesForFTE();
            var totalPay = employeeFinances.CalculatePay(empFTE);
            var totalRewards = employeeFinances.CalculateRewards(empFTE);
            Console.WriteLine("totalPay {0}",totalPay);
            Console.WriteLine("totalRewards {0}",totalRewards);
            Console.Read();
        } 
    }
}
