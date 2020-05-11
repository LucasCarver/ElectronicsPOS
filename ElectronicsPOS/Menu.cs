using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicsPOS
{
    class Menu
    {
        public static void PrintMenu(List<Product> productList)
        {
            int index = 1;

            foreach(Product p in productList)
            {
                Console.Write($"{index}. ");
                DisplayProduct.DrawProduct(p);
                Console.WriteLine("=============================");
                index++;

            }
        }
    }
}
