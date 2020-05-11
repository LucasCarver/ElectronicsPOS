using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicsPOS
{
    class Cash : Payment
    {
        public double LegalTender { get; set; }
        public double Change { get; set; }

        public override void MakePayment()
        {
            while (true)
            {
                Console.WriteLine("How much money are you paying with?");
                LegalTender = double.Parse(Console.ReadLine());
                Change = Total - LegalTender;
                if (Change >= 0)
                {
                    Console.WriteLine($"Your change is {Change}");
                }
                else
                {
                    Console.WriteLine("Uh oh, let's try this again.");
                    continue;
                }
            }
        }


    }
}
