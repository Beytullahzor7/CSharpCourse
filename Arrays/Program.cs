using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            string[] students2 = new[] { "ali", "veli", "mehmet" };
            string[] students3 = { "ali", "veli", "mehmet" };
            string[] students4 = new string[3] { "ali", "veli", "mehmet" };

            students[0] = "Ali";
            students[1] = "Veli";
            students[2] = "Mehmet";

            foreach (var student in students)
            {
                Console.WriteLine(student);
                Console.ReadLine();
            }

            string[,] regions = new string[5, 3]
            {
                {"istanbul","izmit","balıkesir" },
                {"ankara","konya","kırıkkale" },
                {"adana","mersin","antalya" },
                {"samsun","ordu","giresun" },
                {"izmir","mugla","manisa" },
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
