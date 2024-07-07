
using Online_Shopping.CommandPattern;
using Online_Shopping.FactoryMethodPattern;
using Online_Shopping.InsertionSort;
using Online_Shopping.SingletonPattern;
using Online_Shopping.StatePattern;
using System.Diagnostics;

namespace Online_Shopping
{
    public class Program
    {

        static void Main(string[] args)
        {
     
        
            SingletonandObserverDemonstration singletonandObserverDemonstration = new SingletonandObserverDemonstration();
            singletonandObserverDemonstration.Run();

            CommandDemonstration commandDemonstration = new CommandDemonstration();
            //commandDemonstration.Run();


            StateDemonstration stateDemonstration = new StateDemonstration();
            //stateDemonstration.Run();


            ProductFactory factory = new ConcreteProductFactory();

            IProduct product = factory.CreateProduct();

            product.DisplayInfo();


            SorteringsAlgoritmer sorteringsAlgoritmer = new SorteringsAlgoritmer();
            //sorteringsAlgoritmer.Run();

            InsertionSortAlgorithm insertionSortAlgorithm = new InsertionSortAlgorithm();
            //insertionSortAlgorithm.Main();

           

        }
    }
}

    









            /* var product1 = new Product("Laptop", 999);
             var product2 = new Product("Headphones", 600);
             var product3 = new Product("Smartphone", 900);
             var product4 = new Product("Tablet", 500);
             var product5 = new Product("Smartwatch", 780);

             // Skapa en instans av varukorgen
             var shoppingCart = ShoppingCart.Instance;

             // Anslut e-postavisering
             shoppingCart.AttachObserver(new EmailNotificationObserver());

             // Lägg till produkter i varukorgen
             shoppingCart.AddProduct(product1);
             shoppingCart.AddProduct(product2);
             shoppingCart.AddProduct(product3);
             shoppingCart.AddProduct(product4);
             shoppingCart.AddProduct(product5);

             // Visa produkter i varukorgen
             Console.WriteLine("Products in the shopping cart:");
             shoppingCart.DisplayProducts();

             // Ta bort en produkt
               /*Console.WriteLine("\nRemoving product...");
               shoppingCart.RemoveProduct(product2);

               // Visa produkter i varukorgen efter borttagning
               Console.WriteLine("\nProducts in the shopping cart after removal:");
               shoppingCart.DisplayProducts();*/




            
        
           
        
    


