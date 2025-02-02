using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciple
{
    public class Employee
    {

        public string EmployeeType { get; set; }
        public double TotalHoursWorked { get; set; }

        public void Save(Employee emp)
        {

            try
            {
                //code for saving
            }
            catch (Exception ex)
            {

                Logger logger = new Logger();
                logger.LogError(ex.Message);

                //System.IO.File.WriteAllText("C://log.txt", ex.Message);
            }

        }
       
    }

    public enum empType
    {
        FullTime,
        PartTime,
        Contractor
    }
}
