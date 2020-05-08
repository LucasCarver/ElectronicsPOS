using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ElectronicsPOS
{
    class ProductList
    {
        public List<Product> Products { get; set; }
        public static void ProductFileToList(List<Product> products)
        {
            string[] productsArray;
            StreamReader reader = new StreamReader("../../Product_List.txt");
            string line = reader.ReadLine();
            while (line != null)
            {
                productsArray = line.Split('|');
                products.Add(new Product(productsArray[0], productsArray[1], productsArray[2], double.Parse(productsArray[3])));
                line = reader.ReadLine();
            }
            reader.Close();
        }
    }
}
