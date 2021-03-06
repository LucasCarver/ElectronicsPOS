﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicsPOS
{
    class CartView
    {
        public static void DrawCart()
        {
            string format = "{0,-30} | {1,8} | {2,12:C2} | {3,12:C2}";
            Console.WriteLine(format, "NAME", "QUANTITY", "PRICE", "TOTAL");
            foreach (CartObject item in Cart.CartList)
            {
                Console.WriteLine(format, item.Item.Name ,item.ItemQuantity, item.Item.Price, item.Item.Price * item.ItemQuantity);
            }
        }
    }
}
