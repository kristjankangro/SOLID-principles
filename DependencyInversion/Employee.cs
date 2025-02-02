namespace DependencyInversion;

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
            throw new Exception("The method or operation is not implemented.");
        }
        catch (Exception ex)
        {
            
            var isFileLog = true;
            var isDBLog = false;
            if (isFileLog)
            {
                ILogger fileLogger = new FileLogger();
                fileLogger.LogError(ex.Message);
            }
            
            if (isDBLog)
            {
                ILogger logger = new DatabaseLogger();
                logger.LogError(ex.Message);
            }
        }

    }
       
}