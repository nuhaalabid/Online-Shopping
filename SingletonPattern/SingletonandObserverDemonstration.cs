using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Shopping.SingletonPattern
{
    public class SingletonandObserverDemonstration
    {
        public void Run()
        {
         var product1 = new Product("Laptop", 999);
         var product2 = new Product("Headphones", 600);
         var product3 = new Product("Smartphone", 850);
         var product4 = new Product("Tablet", 400);
         var product5 = new Product("Smartwatch", 780);

         // Skapa en instans av varukorgen
         var shoppingCart = ShoppingCart.Instance;


         // Anslut e-postavisering
         shoppingCart.AttachObserver(new EmailNotificationObserver());


         shoppingCart.AddProduct(product1);
         shoppingCart.AddProduct(product2);
         shoppingCart.AddProduct(product3);
         shoppingCart.AddProduct(product4);
         shoppingCart.AddProduct(product5);

         Console.WriteLine("Products in the shopping cart:");
         shoppingCart.DisplayProducts();

         Console.WriteLine();

         Console.WriteLine("Removing product...");
         shoppingCart.RemoveProduct(product2);

         Console.WriteLine("Products in the shopping cart after removal:");
         shoppingCart.DisplayProducts();

     }
    }
    }

