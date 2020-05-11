using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicsPOS
{
    class DisplayProduct
    {
        public static void DrawProduct(Product product)
        {
            string format = "{0,-16}{1,1}";
            Console.WriteLine(format, $"Product: ", $"{product.Name}");
            Console.WriteLine(format, $"Category: ", $"{product.Category}".Trim());
            Console.WriteLine(format, $"Description: ", $"{product.Description}".Trim());
            Console.WriteLine(format, $"Price: ", $"{product.Price:C2}");
        }
    }
}
