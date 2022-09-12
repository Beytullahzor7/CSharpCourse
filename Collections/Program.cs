using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayListCities();
            //NewMethod2();
            //CustomerMethod();
            //NewMethod3();

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("pencil", "kalem");
            dictionary.Add("computer", "bilgisayar");

            //Console.WriteLine(dictionary["computer"]);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key);

            }

            Console.ReadLine();
        }

        private static void NewMethod3()
        {
            List<string> listString = new List<string>();
            listString.Add("Samsun");
            listString.Add("Ankara");
            listString.Add("Izmir");
            listString.Add("Mugla");
            listString.Add("Antalya");
            listString.Add("Samsun");

            listString.Insert(4, "Adana");

            int firstIndex = listString.IndexOf("Samsun");
            int lastIndex = listString.LastIndexOf("Samsun");

            Console.WriteLine("First Index : " + firstIndex);
            Console.WriteLine("Last Index : " + lastIndex);
        }

        private static void CustomerMethod()
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer(1, "Beytullah"));
            customers.Add(new Customer(2, "Merve"));

            int countCustomers = customers.Count;
            Console.WriteLine(countCustomers);

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.id + ". " + customer.FirstName);
            }
        }

        private static void NewMethod2()
        {
            List<string> listOfCities = new List<string>();
            listOfCities.Add("Samsun");
            listOfCities.Add("Izmir");
            listOfCities.Add("Bursa");

            for (int i = 0; i < listOfCities.Count; i++)
            {
                Console.WriteLine(listOfCities[i]);
            }
        }

        private static void ArrayListCities()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Samsun");
            cities.Add('K');
            cities.Add(9);

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }

    class Customer
    {
        public int id { get; set; }
        public string FirstName { get; set; }

        public Customer(int id, string firstName)
        {
            this.id = id;
            FirstName = firstName;
        }

        public void removeAllCusomersMatchWith(List<Customer> objects)
        {
            objects.RemoveAll(i => i.FirstName == "Ahmet");
        }
    }
}
