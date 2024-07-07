using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Shopping.StatePattern
{
    public interface IPaymentState
    {
        void ProcessPayment(Product product);
    }
}

