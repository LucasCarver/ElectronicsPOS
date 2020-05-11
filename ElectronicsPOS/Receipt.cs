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
            Console.WriteLine("Thank you for shopping with us");
            CartView.DrawCart();
            Console.WriteLine();
            Console.WriteLine($"Subtotal: {Cart.GetSubTotal()}");
            Console.WriteLine($"Sales Tax: {Cart.GetSalesTax()}");
            Console.WriteLine($"Total: {Cart.GetGrandTotal()}");

            GetPaymentReceipt(Checkout.PaymentType);
            Console.WriteLine();
            Console.WriteLine("Pleae visit us again soon!");

        }

        public static void GetPaymentReceipt(int userPaymentNumber)
        {
            if(userPaymentNumber == 1)
            {
                
                Console.WriteLine($"(Cash tendered: {Checkout.CashMoney.LegalTender}");
                Console.WriteLine($"(Change: {Checkout.CashMoney.Change}");
            }
            else if(userPaymentNumber == 2)
            {
                Console.WriteLine("Thank you for your check payment. Your balance is $0.");
            }
            else if (userPaymentNumber == 3)
            {
                Console.WriteLine($"Your credit card has been charged and you balance is $0");
            }
        }
            

        

    }
}
