using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Shopping.StatePattern
{
    public class PaymentContext
    {
        private IPaymentState _state;

        public PaymentContext(IPaymentState State)
        {
            _state = State;
        }

        public void SetState(IPaymentState state)
        {
            _state = state;
        }

        public void ProcessPayment(Product product)
        {
            _state.ProcessPayment(product);
        }
    }
}
