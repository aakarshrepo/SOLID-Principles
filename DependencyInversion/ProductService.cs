using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.DependencyInversion
{
    public class ProductService
    {
        private readonly ILog _log;
        //private readonly FileLogger _fileLogger = new FileLogger();
        //private readonly DatabaseLogger _databaseLogger = new DatabaseLogger();

        //public void LogToFile(string message)
        //{
        //    _fileLogger.log(message);
        //}

        //private readonly DatabaseLogger _databaseLogger = new DatabaseLogger();

        //public void LogToDatabase(string message)
        //{
        //    _databaseLogger.Log(message);
        //}

        public ProductService(ILog log)
        {
            _log = log;
        }

        public void Log(string message)
        {
            _log.log(message);
        }

    }
}
