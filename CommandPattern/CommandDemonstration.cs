using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Shopping.CommandPattern
{
    public class CommandDemonstration
    {
        public void Run()
        {
            
            var shoppingCart = new ShoppingCart();

            var product1 = new Product("Laptop", 999);

            var commandHandler = new CommandHandler();

            Console.WriteLine();
            ICommand addCommand = commandHandler.CreateCommand("AddProduct", shoppingCart, product1);
            addCommand.Execute();

            var product2 = new Product("Headphones", 600);

            
            ICommand removeCommand = commandHandler.CreateCommand("RemoveProduct", shoppingCart, product2);
            removeCommand.Execute();
        }
    }

}
    


