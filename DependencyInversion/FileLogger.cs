using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.DependencyInversion
{
    public class FileLogger : ILog
    {
        public void log(string message)
        {
            Console.WriteLine("Inside Log method of FileLogger.");
            logToFile(message);
        }
        private void logToFile(string message)
        {
            Console.WriteLine("Method: LogToFile, Text: {0}", message);
        }
    }
}
