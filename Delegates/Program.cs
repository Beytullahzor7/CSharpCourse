using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MyDelegate();
    public delegate void MyDelegate2(string text);
    public delegate int MyDelegate3(int number1, int number2);
    public class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.SendMessage();
            //customerManager.ShowAlert();

            //  CustomerManagerin sendMessage metoduna bir delege atadık.
            MyDelegate myDelegate = customerManager.SendMessage;

            myDelegate += customerManager.ShowAlert;

            myDelegate -= customerManager.SendMessage; //Sonradan istedigimiz islemi silebiliriz
            myDelegate();


            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            myDelegate2 += customerManager.ShowAlert2;

            myDelegate2("Hello");

            Matematik matematik = new Matematik();
            MyDelegate3 myDelegate3 = matematik.Topla;

            //  Return type i olan bir delege verildiginde en son islem gecerli olur
            //  Yani once toplama ardindan carpma islemini vermistik ikisinin de return type i oldugu icin
            //  En son verdigimiz carpma islemi gecerli oldu ve 24 sonucu ekrana yazildi
            myDelegate3 += matematik.Carp;

            var result = myDelegate3(4, 6);
            Console.WriteLine(result);

            // Get Random Number
            Func<int> getRandomNumber = () => new Random().Next(100);
            Console.WriteLine(getRandomNumber());


            Console.ReadLine();

        }
    }

    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello");
        }

        public void ShowAlert()
        {
            Console.WriteLine("Be Careful!");
        }

        public void SendMessage2(string message)
        {
            Console.WriteLine(message);
        }

        public void ShowAlert2(string alert)
        {
            Console.WriteLine(alert);
        }
    }

    public class Matematik
    {
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

    }
}
