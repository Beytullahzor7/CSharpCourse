using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro();

            try
            {
                Find();
            }
            catch (RecordNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }

        private static void Find()
        {
            List<string> students = new List<string> { "Ahmet", "Mehmet", "Veli" };

            if (!students.Contains("Velsi"))
            {
                throw new RecordNotFoundException("Record Not Found!");
            }

            else
            {
                Console.WriteLine("Record Found!");
            }
        }

        private static void ExceptionIntro()
        {
            try
            {
                string[] students = new string[3] { "Ali", "Ahmet", "Ayse" };
                students[3] = "Veli";
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
