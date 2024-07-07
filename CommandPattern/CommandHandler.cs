using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Shopping.CommandPattern
{
    public class CommandHandler
    {
        public ICommand CreateCommand(string commandType, ShoppingCart shoppingCart, Product product)
        {
            switch (commandType)
            {
                case "AddProduct":
                    return new AddProductCommand(shoppingCart, product);
                case "RemoveProduct":
                    return new RemoveProductCommand(shoppingCart, product);
                default:
                    throw new ArgumentException("Invalid command type");
            }
        }
    }
}
