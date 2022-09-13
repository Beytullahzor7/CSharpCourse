using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();

            List<string> result = utilities.BuildList<string>("Ankara", "Samsun");
            List<Customer> customers = utilities.BuildList<Customer>(new Customer(), new Customer());

            foreach (var itemCustomer in customers)
            {
                Console.WriteLine(itemCustomer.Name);
            }

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }

    class Utilities
    {
        public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);
        }
    }

    class Customer
    {
        public string Name { get; set; }
    }

    class Product
    {

    }

    interface ICustomerDal
    {
        List<Customer> GetAll();
        Customer Get(int id);
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
    }

    interface IProductDal
    {
        List<Product> GetAll();
        Product Get(int id);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }

    //  Restriction : Sadece referans tipler diamond yerine gecebilirler.
    //  Deger tipleri kullanmak istersek hata verir
    interface IRepository2<T> where T : class
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T t);
        void Update(T t);
        void Delete(T t);
    }

    //  Dogru Kullanim
    interface IRepository<T>
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T t);
        void Update(T t);
        void Delete(T t);
    }
    interface IProductDal2 : IRepository<Product>
    {

    }

    interface ICustomerDal2 : IRepository<Customer>
    {

    }

    class ProductDal : IProductDal2
    {
        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Product t)
        {
            throw new NotImplementedException();
        }

        public void Update(Product t)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product t)
        {
            throw new NotImplementedException();
        }
    }
}
