using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Shopping.StatePattern
{
    public class PaymentInProgressState: IPaymentState
    {
        public void ProcessPayment(Product product)
        {
            Console.WriteLine($"Processing payment for product: {product.Name} Price: {product.price}$");

        }
    }
}
