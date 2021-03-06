﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicsPOS
{
    class Cart
    {
        public static double SubTotal { get; set; }
        public static double SalesTax { get; set; }
        public static double GrandTotal { get; set; }
        public static List<CartObject> CartList { get; set; } = new List<CartObject>();
        public static double GetSubTotal()
        {
            double subTotal = 0;
            for (int i = 0; i < CartList.Count; i++)
            {
                subTotal += CartList[i].Item.Price * CartList[i].ItemQuantity;
            }
            return subTotal;
        }
        public static double GetSalesTax()
        {
            return GetSubTotal() * .06;
        }
        public static double GetGrandTotal()
        {
            return GetSubTotal() + GetSalesTax();
        }
        public static void Clear()
        {
            List<CartObject> deleteList = new List<CartObject>();
            foreach (CartObject entry in CartList)
            {
                deleteList.Add(entry);
            }
            foreach(CartObject entry in deleteList)
            {
                CartList.Remove(entry);
            }
        }
    }
}
