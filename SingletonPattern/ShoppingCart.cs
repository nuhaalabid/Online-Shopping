
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Shopping.SingletonPattern
{
    public class ShoppingCart
    {
         private bool notificationSent;
         private static ShoppingCart instance;
         private List<Product> products;
         private List<IObserver> observers;


         private ShoppingCart()
         {
             products = new List<Product>();
             observers = new List<IObserver>();
         }

         public static ShoppingCart Instance
         {
             get
             {
                 if (instance == null)
                 {
                     instance = new ShoppingCart();
                 }
                 return instance;
             }
         }

         public void AddProduct(Product product)
         {
             products.Add(product);
             NotifyObservers();
         }

         public void RemoveProduct(Product product)
         {
             products.Remove(product);
             NotifyObservers();
         }

         public void AttachObserver(IObserver observer)
         {
             observers.Add(observer);
         }

         public void DetachObserver(IObserver observer)
         {
             observers.Remove(observer);
         }


         private void NotifyObservers()
         {
             if (!notificationSent)
             {
                 foreach (var observer in observers)
                 {
                     observer.Update();
                 }

                 notificationSent = true;
             }

             // Återställ flaggan efter varje meddelande
             notificationSent = false;
         }

         public void DisplayProducts()
         {
             foreach (var product in products)
             {
                 Console.WriteLine(product);
             }
         }
    }
}
