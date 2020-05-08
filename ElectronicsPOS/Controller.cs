using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace ElectronicsPOS
{
    class Controller
    {
        //create a list of cart objects

        public void Welcome()
        {
            ProductList.ProductFileToList();
            // Menu.DrawMenu(ProductList.Products); 
            Console.WriteLine("Please choose a product by number or type checkout");
            string input = Console.ReadLine().ToLower().Trim();
            if (input == "checkout")
            {
                //call checkout method
            }
            else
            {

                int userChoice = int.Parse(input);
                //DisplayProduct.DrawProduct(ProductList.Products[userChoice - 1]);
                Console.WriteLine("How many would you like?");
                int userQuantity = int.Parse(Console.ReadLine());
                //Cart.CartList.Add(new CartObject(ProductList.Products[userChoice - 1]), userQuantity);
            }



        }

    }
}
