using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    // The adapter for the card machine
    class CardAdapter : Payment
    {
        private ICard card;
        private int id;

        public override void HandlePayment(UIInfo info, float price)
        {
            if (info.Payment == UIPayment.CreditCard)
            {
                card = new CreditCard();
            }
            else //default case; card = debitcard.
            {
                card = new DebitCard();
            }

            card.Connect();
            id = card.BeginTransaction(price);
            card.EndTransaction(id);
        }
    }
}
