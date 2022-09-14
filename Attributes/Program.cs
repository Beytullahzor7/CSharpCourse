using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Beytullah",
                LastName = "Zor",
                Age = 23
            };

            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
        }
    }

    [ToTable("Customers")]
    class Customer
    {
        public int Id { get; set; }

        [RequiredProperty]
        public string FirstName { get; set; }

        [RequiredProperty]
        public string LastName { get; set; }

        [RequiredProperty]
        public int Age { get; set; }
    }

    class CustomerDal
    {

        //  Obsolete hazir bir attribute dir. Add metodunu projede kullanan bazi yerler oldugunu dusunelim
        //  bu yüzden Add metoduna dokunamiyoruz ve onun yeni bir versiyonunu yaziyoruz
        //  Bundan sonra Add methodunu kullanmak isteyenler icin de Obsolete attribute yi kullanarak
        //  bir uyarı vermis oluyoruz ve güncellenmis methodun kullanilmasina tesvik ediyoruz
        [Obsolete("Don't use Add, instead use AddNew Method")]
        public void Add(Customer customer)
        {
            Console.WriteLine("{0}, {1}, {2}, {3} added",
                customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }

        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0}, {1}, {2}, {3} added",
                customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
    }

    //  Sadece property seviyesinde kullanima actik
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    class RequiredPropertyAttribute : Attribute
    {

    }

    //  Sadece class seviyesinde kullanima actik
    [AttributeUsage(AttributeTargets.Class)]
    class ToTableAttribute : Attribute
    {
        private string _tableName;

        public ToTableAttribute(string _tableName)
        {
            this._tableName = _tableName;
        }
    }
}
