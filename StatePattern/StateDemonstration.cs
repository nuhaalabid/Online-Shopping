using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Shopping.StatePattern
{
    public class StateDemonstration
    {
        public void Run()
        {
            Console.WriteLine();

            PaymentContext paymentContext = new PaymentContext(new PaymentInProgressState());

            Product product1 = new Product("Laptop", 999);
            Product product2 = new Product("Smartphone", 850);

            paymentContext.ProcessPayment(product1); // Betalning pågår för laptop
            paymentContext.ProcessPayment(product2); // Betalning pågår för smartphone

            paymentContext.SetState(new PaymentCompletedState());

            paymentContext.ProcessPayment(product1); // Betalning har redan slutförts


        }
    }
    }

