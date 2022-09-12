using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlServer server = new SqlServer();
            server.Add();

            MySql mySql = new MySql();
            mySql.Add();


            Console.ReadLine();
        }
    }

    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added by Default");
        }

        public virtual void Delete()
        {
            Console.WriteLine("Deleted by Default");
        }
    }

    class SqlServer : Database
    {
        public override void Add()
        {
            Console.WriteLine("Added By SQL Code");
            //base.Add();
        }
    }

    class MySql : Database
    {

    }
}
