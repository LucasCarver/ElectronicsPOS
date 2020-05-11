using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicsPOS
{
    class CartView
    {
        public static void DrawCart()
        {
            string format = "{0,30} | {1,4} | {2,6:C2}";
            Console.WriteLine(format, "NAME", "QUANTITY", "PRICE");
            foreach (CartObject item in Cart.CartList)
            {
                Console.WriteLine(format, $"{item.Item.Name} {item.ItemQuantity} {item.Item.Price} {item.Item.Price * item.ItemQuantity}");
            }
        }
    }
}
