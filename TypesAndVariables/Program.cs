using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            int number1 = 10;
            char ch1 = 'A';
            var number7 = 7;
            number7 = 'A'; //ASCII = A -> 65


            Console.WriteLine("Number 1 is {0}", number1);
            Console.WriteLine("Character 1 is {0}", ch1);

            Console.WriteLine(Days.Sunday);
            Console.WriteLine((int)Days.Sunday);
            Console.WriteLine("Number 7 is {0}", number7);


            Console.ReadLine();
        }
    }

    enum Days
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
}
