using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(5);
            customerManager.List();

            Product product = new Product();
            Product product2 = new Product(1, "Beytullah");

            Console.ReadLine();
        }
    }

    class CustomerManager
    {

        private int _count = 15; //Best Practice = Private bir field _ ile baslatilir

        public CustomerManager()
        {

        }

        public CustomerManager(int count)
        {
            _count = count;
        }


        public void Add()
        {
            Console.WriteLine("Added!");
        }

        public void List()
        {
            Console.WriteLine("Listed {0} items", _count);
        }
    }

    class Product
    {
        private int _id;
        private string _name;
        public Product()
        {

        }

        public Product(int id, string name)
        {
            _id = id;
            _name = name;
        }
    }


}
