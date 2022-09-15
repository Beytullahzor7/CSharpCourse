using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{

    //  Uygulamada bir hareket oldugunda, o harekete ek olarak
    //  yapmak istedigimiz bir islem varsa bunu event ile yapabiliriz

    //  Eventler delegelerin kullanimi ile yapilabilecek islemlerdir
    public delegate void StockControl();
    public class Product
    {
        private int _stock;

        public Product(int stock)
        {
            _stock = stock;
        }

        public event StockControl StockControlEvent;
        public string ProductName { get; set; }

        public int Stock
        {
            get
            {
                return _stock;
            }

            set
            {
                _stock = value;

                if (value <= 15 && StockControlEvent != null)
                {
                    StockControlEvent();
                }
            }
        }

        public void Sell(int amount)
        {
            Stock -= amount;
            Console.WriteLine("{1} Stock Amount : {0}", Stock, ProductName);
        }
    }
}
