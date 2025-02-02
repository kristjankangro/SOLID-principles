using System;
using lsp;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lsp");

            Employee empFTE = new Employee() { EmployeeType = empType.FullTime.ToString(), TotalHoursWorked = 10 };
            Employee empPTE = new Employee() { EmployeeType = empType.PartTime.ToString(), TotalHoursWorked = 10 };
            Employee empContractor = new Employee { EmployeeType = empType.Contractor.ToString(), TotalHoursWorked = 10 };

            EmployeeFinances employeeFinances = new EmployeeFinancesForContractor();
            var totalPay = employeeFinances.CalculatePay(empContractor);
            var totalRewards = employeeFinances.CalculateRewards(empContractor);
            Console.WriteLine("totalPay {0}",totalPay);
            Console.WriteLine("totalRewards {0}",totalRewards);
            Console.Read();
        } 
    }
}
