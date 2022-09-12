using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDemo
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            //  Using kullanımı, garbage collectoru beklemeden scope bittiginde o anki nesneyi
            //  zorla bellekten atar
            using (ETradeContext context = new ETradeContext())
            {
                //  Entity Framework veritabanındaki tabloya erisim kodu
                return context.Products.ToList();
            }
        }

        public void Add(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                //  Entity Framework veritabanındaki tabloya erisim kodu
                //context.Products.Add(product);
                var entity = context.Entry(product);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }

        }

        public void Update(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                // Bu product icin context uzerinden abone ol. Veri tabanındaki product ile
                // bizim gonderdigimiz productu esitler
                var entity = context.Entry(product);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
