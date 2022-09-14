using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dortIslem = new DortIslem(4, 5);
            //Console.WriteLine(dortIslem.Topla2()); //comes from ctor
            //Console.WriteLine(dortIslem.Topla(2, 3));


            var tip = typeof(DortIslem);
            //Calisma aninda karar verdik bir reflection ornegidir
            //DortIslem dortIslem = (DortIslem)Activator.CreateInstance(tip, 5, 6); 
            //Console.WriteLine(dortIslem.Topla(4, 5));
            //Console.WriteLine(dortIslem.Topla2());

            var instance = Activator.CreateInstance(tip, 6, 7);

            //  GetMethod ile istedigimiz methoda ulastik
            //  Invoke ile de ulastigimiz bu methodu calistirdik
            //Console.WriteLine(instance.GetType().GetMethod("Topla2").Invoke(instance, null));

            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");
            Console.WriteLine(methodInfo.Invoke(instance, null));


            Console.WriteLine("---------------------------------------------------------------------");


            var metodlar = tip.GetMethods();

            foreach (var item in metodlar)
            {
                Console.WriteLine("Metod Adi : {0}", item.Name);
            }

            Console.ReadLine();
        }
    }

    public class DortIslem
    {
        private int _sayi1;
        private int _sayi2;

        public DortIslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }

        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }
    }
}
