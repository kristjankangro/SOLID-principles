using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion
{
    public class EmployeeOperations
    {
        public string ReportHours(Employee emp)
        {
            return "report";
        }
    }
}
