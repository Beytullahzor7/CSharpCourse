using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EmployeeManager employeeManager = new EmployeeManager(new MySQL());
            EmployeeManager employeeManager = new EmployeeManager(new Oracle());
            employeeManager.Add();

            Console.ReadLine();
        }
    }

    class EmployeeManager
    {
        private ILogger Logger;

        public EmployeeManager(ILogger logger)
        {
            Logger = logger;
        }

        public void Add()
        {
            Console.WriteLine("Employee Added");
            Logger.Log();
        }
    }

    interface ILogger
    {
        void Log();
    }

    class MySQL : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged To MySQL");
        }
    }

    class Oracle : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged To Oracle");
        }
    }
}
