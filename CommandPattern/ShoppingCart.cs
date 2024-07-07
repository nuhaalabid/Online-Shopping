using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Shopping.CommandPattern
{
    public class ShoppingCart
    {
        private List<Product> products;

        public ShoppingCart()
        {
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
            Console.WriteLine($"Product added: {product.Name}, {product.price}$");
        }

        public void RemoveProduct(Product product)
        {
            products.Remove(product);
            Console.WriteLine($"Product removed: {product.Name},{product.price}$");
        }
    }
}
