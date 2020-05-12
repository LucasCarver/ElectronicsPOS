using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ElectronicsPOS
{
    class ProductList
    {
        public static List<Product> Products { get; set; } = new List<Product>();
        public static void ProductFileToList()
        {
            string[] productsArray;
            StreamReader reader = new StreamReader("../../../Product_List.txt");
            string line = reader.ReadLine();
            double temp;
            while (line != null)
            {
                productsArray = line.Split('|');
                temp = double.Parse(productsArray[3]);
                Products.Add(new Product(productsArray[0], productsArray[1], productsArray[2], temp));
                line = reader.ReadLine();
            }
            reader.Close();
        }
        public static void AddProductToFile()
        {
            double temp;
            Console.WriteLine("Enter product name: ");
            string name = Console.ReadLine().Trim();
            Console.WriteLine("Enter category: ");
            string category = Console.ReadLine().Trim();
            Console.WriteLine("Enter description: ");
            string description = Console.ReadLine().Trim();

            while (true)
            {
                Console.WriteLine("Enter price: ");
                string price = Console.ReadLine().Trim();
                try
                {
                    temp = double.Parse(price);
                    if (temp < 0)
                    {
                        throw new Exception("Number must be positive.");
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a number amount.");
                    continue;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Products.Add(new Product(name, category, description, temp));
            StreamWriter writer = new StreamWriter("../../../Product_List.txt");
            foreach (Product product in Products)
            {
                writer.WriteLine($"{product.Name} | {product.Category} | {product.Description} | {product.Price}");
            }
            writer.Close();
        }
        public static void RemoveProductFromFile()
        {
            Console.WriteLine("Enter menu item number: ");
            string input = Console.ReadLine().Trim();
            int temp = int.Parse(input);
            Products.RemoveAt(temp - 1);
            StreamWriter writer = new StreamWriter("../../../Product_List.txt");
            foreach (Product product in Products)
            {
                writer.WriteLine($"{product.Name} | {product.Category} | {product.Description} | {product.Price}");
            }
            writer.Close();
        }
    }
}
