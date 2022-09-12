using System;
using System.Linq;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add();

            var result = Add2(5, 7);
            Console.WriteLine(result);


            int number1 = 40;
            int number2 = 50;
            var result2 = Add3(ref number1, number2);
            Console.WriteLine(result2);
            Console.WriteLine(number1); //new value of number1 will be 30 because of the ref keyword
            //ref = deger tiplerin referans tip gibi kullanilmasini saglar

            Console.WriteLine("Result Is: " + Add4(3, 4, 2, 5, 6, 6));

            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Hello");
        }

        static int Add2(int number1, int number2)
        {
            return number1 + number2;
        }

        static int Add3(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Add4(int number1, int number2)
        {
            return number1 + number2;
        }

        static int Add4(int number1, int number2, int number3)
        {
            return number1 + number2 + number3;
        }

        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }

    }
}
