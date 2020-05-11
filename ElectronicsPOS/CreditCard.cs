using System;
using System.Text.RegularExpressions;

namespace ElectronicsPOS
{
    class CreditCard : Payment
    {
        public string CreditCardNumber { get; set; }
        public string CVVNumber { get; set; }
        public string Year { get; set; }
        public string Month { get; set; }

        public override void MakePayment()
        {
            GetCreditCardNumber();
            GetExpirationDate();
            GetCVVNumber();

            Console.WriteLine($"Success, your credit card has been charged {Total}");
        }

        public void GetCreditCardNumber()
        {
            while (true)
            {
                Console.WriteLine("What is your credti card number?");
                CreditCardNumber = Console.ReadLine();
                bool isValid = IsValidNumber(CreditCardNumber);
                if (isValid == false)
                {
                    Console.WriteLine("Invalid number, try again.");
                    continue;
                }
                break;
            }
        }

        public void GetExpirationDate()
        {
            while (true)
            {
                               
                Console.WriteLine("What is the two digit expiration month?");
                Month = Console.ReadLine();
                bool isValidMonth = IsValidMonth(Month);
                if (isValidMonth == false)
                {
                    Console.WriteLine("Invalid month, try again.");
                    continue;
                }
                else
                {
                    while (true)
                    {
                        Console.WriteLine("What is the two digit year?");
                        Year = Console.ReadLine();
                        bool isValidYear = IsValidYear(Year);
                        if (isValidYear == false)
                        {
                            Console.WriteLine("Invalid year, try again.");
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                   
                }
                break;
                
            }
        }

        public void GetCVVNumber()
        {
            while (true)
            {
                Console.WriteLine("What is the CVV number?");
                CVVNumber = Console.ReadLine();
                bool validCVV = IsValidCVV(CVVNumber);
                if (validCVV == false)
                {
                    Console.WriteLine("Invalid number, try again.");
                    continue;
                }
                else
                {
                    break;
                }
            }
        }
        public static bool IsValidNumber(string creditCardNumber)
        {
            string pattern = @"^(?:4[0-9]{12}(?:[0-9]{3})?|[25][1-7][0-9]{14}|6(?:011|5[0-9][0-9])[0-9]{12}|3[47][0-9]{13}|3(?:0[0-5]|[68][0-9])[0-9]{11}|(?:2131|1800|35\d{3})\d{11})$";
            Match match = Regex.Match(creditCardNumber, pattern);
            return match.Success;
        }

        public static bool IsValidCVV(string cvvNumber)
        {
            string pattern2 = @"^([0-9]{3,4})$";
            Match match2 = Regex.Match(cvvNumber, pattern2);
            return match2.Success;

        }
        public static bool IsValidMonth(string month)
        {
            string pattern3 = "^0[1-9]|1[012]$";
            Match match3 = Regex.Match(month, pattern3);
            return match3.Success;

        }
        public static bool IsValidYear(string year)
        {
            string pattern4 = "^[0-9][0-9]$";
            Match match4 = Regex.Match(year, pattern4);
            return match4.Success;
        }

    }
}
