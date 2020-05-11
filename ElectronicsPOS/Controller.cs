using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace ElectronicsPOS
{
    class Controller
    {
        public static void Welcome()
        {
            ProductList.ProductFileToList();
            while (true)
            {
                Menu.PrintMenu(ProductList.Products);

                Console.WriteLine("Please choose a product by number or type checkout");

                string input = Console.ReadLine().ToLower().Trim();

                if(input == "admin")
                {
                    Console.WriteLine("\"add\" to add a product\n\"remove\" to remove a product\n\"exit\" to exit");
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                if (input == "exit")
                {
                    break;
                }
                else if (input == "add")
                {
                    ProductList.AddProductToFile();
                    continue;
                }
                else if(input == "remove")
                {
                    ProductList.RemoveProductFromFile();
                    continue;
                }

                int userQuantity = 0;

                int userChoice = 0;

                if (input == "checkout" && Cart.CartList.Count > 0)
                {
                    Checkout.CheckOut();
                    Receipt.DrawReceipt();
                    Console.WriteLine("Thanks for shopping with Best Buy\nAny key to continue.");
                    Console.ReadKey();
                    Cart.Clear();
                    continue;
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
                            Console.WriteLine("Press any key to try again.");
                            Console.ReadKey();
                            continue;
                        }

                        Console.WriteLine("How many would you like?");

                        while (true)
                        {
                            bool isQuant = int.TryParse(Console.ReadLine(), out userQuantity);

                            if (isQuant && userQuantity > 0)
                            {
                                Cart.CartList.Add(new CartObject(ProductList.Products[userChoice - 1], userQuantity));
                                Console.Clear();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Please enter a valid amount:");
                                Console.WriteLine("Press any key to try again.");
                                Console.ReadKey();
                                continue;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid item number:");
                        Console.WriteLine("Press any key to try again.");
                        Console.ReadKey();
                        Console.WriteLine();
                        continue;
                    }
                }
            }
        }
    }
}
