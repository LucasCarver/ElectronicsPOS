using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicsPOS
{
    class Receipt
    {

        public static void DrawReceipt()
        {
            Console.WriteLine("Thank you for shopping with us");
            CartView.DrawCart();


            GetPaymentReceipt(userPaymentNumber);

        }

        public static void GetPaymentReceipt(int userPaymentNumber)
        {
            if(userPaymentNumber == 1)
            {
                Cash c = new Cash();
                Console.WriteLine($"(Cash tendered: {c.LegalTender}");
                Console.WriteLine($"(Change: {c.Change}");
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
