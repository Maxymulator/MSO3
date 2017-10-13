using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab3
{
    static class PrinterHandler
    {
        public static void Print()
        {
            PrintReceipt(50);
        }

        static void PrintTicket()
        {

        }

        static void PrintReceipt(int price)
        {
            MessageBox.Show("Transactie voltooid: U heeft " + price + " cent betaald.");
        }
    }
}
