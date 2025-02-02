using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciple
{
    public class Logger
    {
        public void LogError(string message)
        {
            System.IO.File.WriteAllText("C://log.txt", message);
        }

    }
}
