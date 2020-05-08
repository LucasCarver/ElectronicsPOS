using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicsPOS
{
    class CreditCard : Payment
    {
        public int CreditCardNumber { get; set; }
        public int CVVNumber { get; set; }
       public DateTime ExpirationDate { get; set; }

       
        public static int Year { get; set; }
        public static int Month { get; set; }

        
       
        
        public override void MakePayment()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("What is your credti card number?");

                    CreditCardNumber = int.Parse(Console.ReadLine());

                    Console.WriteLine("What is the expiration month?");
                    Month = int.Parse(Console.ReadLine());
                    Console.WriteLine("What is the month?");
                    Year = int.Parse(Console.ReadLine());
                    ExpirationDate = new DateTime(Year, Month, 1);
                    Console.WriteLine("What is the CVV number?");
                    CVVNumber = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid input. Try again.");
                    continue;
                }
            }

        }
    }
}
