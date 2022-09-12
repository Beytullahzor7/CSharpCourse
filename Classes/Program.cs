using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();


            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Beytullah";
            customer.LastName = "Zor";
            customer.City = "Samsun";

            Customer customer2 = new Customer
            {
                Id = 2,
                FirstName = "Ali",
                LastName = "Yilmaz",
                City = "Ankara"
            };

            Console.WriteLine(customer2.FirstName + " " + customer2.LastName);
            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("Customer Added");
        }

        public void Update()
        {
            Console.WriteLine("Customer Updated!");
        }
    }
}
