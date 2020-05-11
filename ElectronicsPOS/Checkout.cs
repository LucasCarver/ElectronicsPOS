using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicsPOS
{
    class Checkout
    {
        public static int PaymentType { get; set; }
        public static Cash CashMoney { get; set; } = new Cash();
        public static Check CheckMoney { get; set; } = new Check();
        public static CreditCard CreditMoney { get; set; } = new CreditCard();

        public static void CheckOut()
        {
            string format = "{0, 59}{1, 12}";
            CartView.DrawCart();

            Console.WriteLine(format, "Sub Total: ", $"{Cart.GetSubTotal():C2}");
            Console.WriteLine(format, "Sales Tax: ", $"{Cart.GetSalesTax():C2}");
            Console.WriteLine(format, "Grand Total: ", $"{Cart.GetGrandTotal():C2}");

            PaymentType = GetPaymentType();
            if (PaymentType == 1)
            {
                CashMoney.MakePayment();
            }
            else if (PaymentType == 2)
            {
                CheckMoney.MakePayment();
            }
            else if (PaymentType == 3)
            {
                CreditMoney.MakePayment();
            }
        }
        public static int GetPaymentType()
        {
            string input;
            int payNum;
            while (true)
            {
                Console.WriteLine("Please select payment type.");
                Console.WriteLine("1. Cash");
                Console.WriteLine("2. Check");
                Console.WriteLine("3. Credit Card");
                input = Console.ReadLine().ToLower().Trim();
                if (input == "cash" || input == "check" || input.Contains("credit") || input.Contains("card"))
                {
                    if (input == "cash")
                    {
                        return 1;
                    }
                    else if (input == "check")
                    {
                        return 2;
                    }
                    else if (input == "credit" || input == "card" || input == "credit card")
                    {
                        return 3;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please try again.");
                        continue;
                    }
                }
                try
                {
                    payNum = int.Parse(input);
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    continue;
                }
                if (payNum != 1 && payNum != 2 && payNum != 3)
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    continue;
                }
                else
                {
                    return payNum;
                }
            }
        }
    }
}
