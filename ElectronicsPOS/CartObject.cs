using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicsPOS
{
    class CartObject
    {
        public Product Item{ get; set; }
        public int ItemQuantity { get; set; }
        public CartObject(Product item, int itemQuantity)
        {
            Item = item;
            ItemQuantity = itemQuantity;
        }
    }
}
