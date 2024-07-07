using Online_Shopping.SingletonPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Shopping.CommandPattern
{
    public class AddProductCommand : ICommand
    {
        private ShoppingCart _shoppingCart;
        private Product _product;

        public AddProductCommand(ShoppingCart shoppingCart, Product product)
        {
            _shoppingCart = shoppingCart;
            _product = product;
        }
        public void Execute()
        {
            _shoppingCart.AddProduct(_product);
        }

    }
}
