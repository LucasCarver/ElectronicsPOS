using System;

namespace ElectronicsPOS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("BEST \nBUY");
            Console.WriteLine("====");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("Welcome to the Best Buy POS Terminal");
            Console.WriteLine("------------------------------------");

            Controller.Welcome();

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Thanks for shopping at Best Buy!");
        }
    }
}
