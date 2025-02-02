using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion
{
    public class Employee
    {

        public string EmployeeType { get; set; }
        public double TotalHoursWorked { get; set; }

        public ILogger logger;

        public Employee(ILogger InputLogger)
        {
            logger = InputLogger;
        }

        public void Save(Employee emp)
        {

            try
            {
                //code for saving
                throw new Exception();
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);

            }

        }
       
    }

    public enum empType
    {
        FullTime,
        PartTime,
        Contractor,
        CLevel
    }
}
