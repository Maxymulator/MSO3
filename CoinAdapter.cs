using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    // The adapter for the coin machine
    class CoinAdapter : Payment
    {
        private IKEAMyntAtare2000 coin = new IKEAMyntAtare2000();
        public override void HandlePayment(UIInfo info, float price)
        {
            coin.starta();
            coin.betala((int)Math.Round(price * 100));
            coin.stoppa();
        }
    }
}
