using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Shopping.FactoryMethodPattern
{
    public class ConcreteProductFactory: ProductFactory
    {
        public override IProduct CreateProduct()
        {

            return new ConcreteProduct("Samsung", 700);

        }

    }
}
