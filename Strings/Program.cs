using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string city = "Samsun";
            string city2 = "Ankara";

            var sentence = "My Name Is Beytullah";
            var result = sentence.Insert(0, "Hello, ");
            var changeSentence = sentence.Replace(" ", "-");
            var result2 = sentence.Remove(2, 4);

            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(changeSentence);
            Console.WriteLine(String.Format("{0} {1}", city, city2));
            Console.ReadLine();
        }
    }
}
