using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion
{
    public interface IEmployeeRewards
    {
        double CalculateRewards(Employee emp);
    }

    public interface IEmployeeFinances : IEmployeeRewards
    {
        double CalculatePay(Employee emp);

        
    }

    public interface IStockOptions : IEmployeeFinances
    {
        double CalculateStockOptions(Employee emp);
    }


    public class EmployeeFinancesForFTE: IEmployeeFinances
    {
        public  double CalculatePay(Employee emp)
        {
            return emp.TotalHoursWorked * 10;
        }

        public  double CalculateRewards(Employee emp)
        {
            return 200;
        }

    
    }

    public class EmployeeFinancesForPTE : IEmployeeFinances
    {
        public  double CalculatePay(Employee emp)
        {
            return emp.TotalHoursWorked * 5;
        }

        public  double CalculateRewards(Employee emp)
        {
            return 150;
        }

    }

    public class EmployeeFinancesForContractor : IEmployeeRewards
    {

        public  double CalculateRewards(Employee emp)
        {
            return 120;
        }
    }

    public class EmployeeFinancesForCLevel : IStockOptions
    {
        public double CalculatePay(Employee emp)
        {
            return 50;
        }

        public double CalculateRewards(Employee emp)
        {
            return 50;
        }

        public double CalculateStockOptions(Employee emp)
        {
            return 50;
        }
    }
}
