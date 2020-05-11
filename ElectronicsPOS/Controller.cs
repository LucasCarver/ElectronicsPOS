using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace ElectronicsPOS
{
    class Controller
    {
        //create a list of cart objects

        public static void Welcome()
        {
            while (true)
            {


                ProductList.ProductFileToList();

                Menu.PrintMenu(ProductList.Products); 

                Console.WriteLine("Please choose a product by number or type checkout");

                string input = Console.ReadLine().ToLower().Trim();

                int userQuantity = 0;

                int userChoice = 0;

                if (input == "checkout")
                {
                    //Checkout.CheckOut();
                    

                    break;
                }
                else
                {

                    bool isNum = int.TryParse(input, out userChoice);

                    if (isNum)
                    {
                        try
                        {

                            DisplayProduct.DrawProduct(ProductList.Products[userChoice - 1]);

                        }
                        catch
                        {
                            Console.WriteLine("Please enter a valid item number:");
                            continue;

                        }

                        Console.WriteLine("How many would you like?");

                        while (true)
                        {

                            bool isQuant = int.TryParse(Console.ReadLine(), out userQuantity);

                            if (isQuant)
                            {
                                Cart.CartList.Add(new CartObject(ProductList.Products[userChoice - 1], userQuantity));
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Please enter a valid amount:");
                                continue;
                            }

                            
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid item number:");
                        Console.WriteLine();
                        continue;
                    }

                }
            }


        }

    }
}
