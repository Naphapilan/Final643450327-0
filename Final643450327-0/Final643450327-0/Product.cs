using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final643450327_0
{
    internal class Product
    {
        private string name;
        private double price = 0;

        public Product(string name,int price)
        {
            this.name = name;   
            this.price += price;

        }
        public double getPrice()
        {
            return price;
        }
    }
}
