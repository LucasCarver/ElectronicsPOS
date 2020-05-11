using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ElectronicsPOS
{
    class ProductList
    {
        public static List<Product> Products { get; set; }
        public static void ProductFileToList()
        {
            string[] productsArray;
            StreamReader reader = new StreamReader("../../Product_List.txt");
            string line = reader.ReadLine();
            while (line != null)
            {
                productsArray = line.Split('|');
                Products.Add(new Product(productsArray[0], productsArray[1], productsArray[2], double.Parse(productsArray[3])));
                line = reader.ReadLine();
            }
            reader.Close();
        }

        public static void AddProductToFile()
        {
            StreamWriter writer = new StreamWriter("../../../Product_List.txt");
            foreach(Product product in Products)
            {
                writer.WriteLine($"{product.Name} | {product.Category} | {product.Description} | {product.Price}");
            }
            writer.Close();
        }
    }

}
