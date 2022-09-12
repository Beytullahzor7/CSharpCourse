using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("i nin degeri: " + i);
            }


            Console.WriteLine("********************");


            for (int i = 0; i < 100; i += 2)
            {
                Console.WriteLine("i nin degeri: " + i);
            }


            Console.WriteLine("********************");


            for (int i = 100; i > 0; i--)
            {
                Console.WriteLine(i * 2);
            }

            whileMethod();

            Console.WriteLine(isNumberPrime(9));

            Console.ReadLine();
        }

        static void whileMethod()
        {
            int number = 10;

            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }

            Console.WriteLine("Now Number Is {0}", number);
        }

        static bool isNumberPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                    i = number; //break loop
                }
            }

            return true;
        }
    }
}
