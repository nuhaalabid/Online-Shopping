using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Shopping.StatePattern
{
    public class PaymentCompletedState: IPaymentState
    {
        public void ProcessPayment(Product product)
        {
            Console.WriteLine("Payment has already been completed.");
        }

    }
}
