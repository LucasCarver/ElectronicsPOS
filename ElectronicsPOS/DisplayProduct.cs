using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicsPOS
{
    class DisplayProduct
    {


        public static void DrawProduct(Product product)
        {
            Console.WriteLine($"Product: {product.Name} \nCategory: {product.Category} \nDescription: {product.Description} \nPrice{product.Price}");
        }
    }
}
