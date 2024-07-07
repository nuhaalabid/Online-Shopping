using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Shopping.FactoryMethodPattern
{
    public class ConcreteProduct : IProduct
    {
        private string name;
        private double price;

        public ConcreteProduct(string name, double price)
        {
            this.name = name;
            this.price = price;

        }
        public void DisplayInfo()
        {
            Console.WriteLine();
            Console.WriteLine("New products...");
            Console.WriteLine($"Product: {name}, Price: {price}$");
        }
    }
}

