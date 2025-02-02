namespace DependencyInversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Employee empFTE = new Employee(new FileLogger()) { EmployeeType = empType.FullTime.ToString(), TotalHoursWorked = 10 };
            Employee empPTE = new Employee(new FileLogger()) { EmployeeType = empType.PartTime.ToString(), TotalHoursWorked = 10 };
            Employee empContractor = new Employee(new FileLogger()) { EmployeeType = empType.Contractor.ToString(), TotalHoursWorked = 10 };

            empFTE.Save(empFTE);
       
            Console.Read();
        } 
    }
}
