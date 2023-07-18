using SOLID_Principles.DependencyInversion;
using System;

namespace SOLID_Principles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Logging to Product Service");

            #region Dependency Inversion 
            ILog objLog = new DatabaseLogger();
            ProductService productService = new ProductService(objLog);
            productService.Log("Started Logging to Product Service");
            #endregion
        }


    }
}
