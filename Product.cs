using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Shopping
{
    public class Product
    {
        public string Name { get; set; }
        public double price { get; set; }
    

        public Product(string name, double price)
        {
            Name = name;
            this.price = price;
        }
        public override string ToString()
        {
            return $"{Name} - {price}$";
        }
    }
}
