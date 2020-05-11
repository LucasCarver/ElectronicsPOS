using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace ElectronicsPOS
{
    class Receipt
    {

        public static void DrawReceipt()
        {
            string format = "{0,15}{1,15}";
            Console.WriteLine("Thank you for shopping with us");
            CartView.DrawCart();
            Console.WriteLine();
            Console.WriteLine(format, $"Subtotal: ", $"{Cart.GetSubTotal():C2}");
            Console.WriteLine(format, $"Sales Tax: ", $"{Cart.GetSalesTax():C2}");
            Console.WriteLine(format, $"Total: ", $"{Cart.GetGrandTotal():C2}");

            GetPaymentReceipt(Checkout.PaymentType);
            Console.WriteLine();
            Console.WriteLine("Pleae visit us again soon!");

        }

        public static void GetPaymentReceipt(int userPaymentNumber)
        {
            if(userPaymentNumber == 1)
            {
                string format = "{0,15}{1,15}";
                Console.WriteLine(format, $"Cash tendered: ", $"{Checkout.CashMoney.LegalTender:C2}");
                Console.WriteLine(format, $"Change: ", $"{Checkout.CashMoney.Change:C2}");
            }
            else if(userPaymentNumber == 2)
            {
                Console.WriteLine($"Thank you for your check payment of {Cart.GetGrandTotal():C2}.");
            }
            else if (userPaymentNumber == 3)
            {
                Console.WriteLine($"Your credit card has been charged {Cart.GetGrandTotal():C2}.");
            }
        }
            

        

    }
}
