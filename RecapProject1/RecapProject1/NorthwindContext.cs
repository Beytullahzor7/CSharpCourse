using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecapProject1.Entities;

namespace RecapProject1
{
    // Veritabani ile Entity Nesnelerini bind edecek yapidir
    public class NorthwindContext : DbContext
    {
        //  Elimde bir Product var ve o Product veritabaninda Products'a karsilik
        //  gelir ben onu direkt olarak tablo gibi Products ismi ile kullanacagim
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
