using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;


namespace ElectronicsPOS
{
    class Check : Payment
    {
        public int CheckNumber { get; set; }
        public override void MakePayment()
        {
            while (true)
            {
                Console.WriteLine("What check number are you paying with?");
                try
                {
                    CheckNumber = int.Parse(Console.ReadLine());
                    if(!(CheckNumber > 0))
                    {
                        Console.WriteLine("Invalid check number.");
                        continue;
                    }
                    Console.WriteLine("Thank you for your payment!");
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("This is not a number. Try again.");
                    continue;
                }
            }
        }
    }
}
