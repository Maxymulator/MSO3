using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    static class PriceCalculator
    {

        public static float CalculatePrice(UIInfo uiInfo)
        {
            float classTarief, discount, returnMultiplier, payFee;
            int tariefeenheden = Tariefeenheden.getTariefeenheden(uiInfo.From, uiInfo.To);

            switch (uiInfo.Class) //bepaal eerste of tweede klas
            {
                case UIClass.FirstClass:
                    classTarief = 3.60f;
                    break;
                default:
                    classTarief = 2.10f;
                    break;
            }

            switch (uiInfo.Way) //oneway of retour; evt met het zicht op nieuwe opties voor meer tickets in de toekomst ook als switch gemaakt
            {
                case UIWay.Return:
                    returnMultiplier = 2f;
                    break;
                default:
                    returnMultiplier = 1f;
                    break;
            }

            switch (uiInfo.Payment) //als switch indien er meer betaalmethoden bij komen met andere fees
            {
                case UIPayment.CreditCard:
                    payFee = 0.50f;
                    break;
                default:
                    payFee = 0f;
                    break;
            }

            switch (uiInfo.Discount) //eventueel met korting
            {
                case UIDiscount.FortyDiscount:
                    discount = 0.6f;
                    break;
                case UIDiscount.TwentyDiscount:
                    discount = 0.8f;
                    break;
                default:
                    discount = 1;
                    break;
            }

            float price = 0.02f * classTarief * discount * tariefeenheden; //basisprijs
            price *= returnMultiplier; // dubbel indien retour
            price += payFee; //specifieke betaalmethoden hebben extra kosten
            return (float)Math.Round(price, 2);
        }
    }
}
