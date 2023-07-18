using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.DependencyInversion
{
    public class DatabaseLogger : ILog
    {
        public void log(string message)
        {
            Console.WriteLine("Inside Log method of DatabaseLogger.");
            logToDatabase(message);
        }
        private void logToDatabase(string message)
        {
            Console.WriteLine("Method: LogToDatabase, Text: {0}", message);
        }
    }
}
