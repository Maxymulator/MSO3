using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab3
{
    static class PrinterHandler
    {
        public static void Print(float price)
        {
            PrintTicket();
            PrintReceipt(price);
        }

        static void PrintTicket()
        {
            MessageBox.Show("Een moment geduld; uw ticket wordt geprint."); //Met een print call; dit is een call naar hardware die we hier niet programmeren.
        }

        static void PrintReceipt(float price)
        {
            MessageBox.Show("Transactie voltooid: U heeft " + price + " euro betaald.");
        }
    }
}
