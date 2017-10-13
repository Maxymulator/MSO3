using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    // The abstract strategy for the payment system
    abstract class Payment
    {
        //handle the payment
        public virtual void HandlePayment(UIInfo info, float price)
        {

        }
    }
}
