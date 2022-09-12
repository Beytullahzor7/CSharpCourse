using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 1550;

            if (number >= 0 && number <= 100)
            {
                Console.WriteLine("Number Is Between 0-100");
            }

            else if (number > 100 && number <= 200)
            {
                Console.WriteLine("Number Is Between 101-200");
            }

            else if (number > 200 || number < 0)
            {
                Console.WriteLine("Number Is Less Than 0 Or Greater Than 200");
            }

            Console.ReadLine();
        }
    }
}
