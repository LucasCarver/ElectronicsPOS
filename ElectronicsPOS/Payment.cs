using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicsPOS
{
    abstract class Payment
    {
        public double Total { get; set; }


        public abstract void MakePayment();
        
    }

}