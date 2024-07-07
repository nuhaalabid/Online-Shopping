using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Shopping.InsertionSort
{
       public class InsertionSortAlgorithm
    { 
        public void Main()
        {
            var products = new Product[]
            {
                new Product("Laptop", 999),
                new Product("Headphones", 600),
                new Product("Smartphone", 850),
                new Product("Tablet", 400),
                new Product("Smartwatch", 780)
            };

            Console.WriteLine("Products before Insertion Sort:");
            DisplayProducts(products);

            var stopwatch = Stopwatch.StartNew();
            InsertionSort.Sort(products);
            stopwatch.Stop();

            Console.WriteLine();
            Console.WriteLine("Products after Insertion Sort:");
            DisplayProducts(products);
            Console.WriteLine($"InsertionSort took time: {stopwatch.ElapsedTicks} ticks!");
        }

        private void DisplayProducts(Product[] products)
        {
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }
    }
}
