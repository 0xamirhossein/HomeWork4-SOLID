using System;
using System.Collections.Generic;
using System.Text;


using HW_L3_02_SOLID.Interfaces;

namespace HW_L3_02_SOLID.Discounts
{
    internal class FixedDiscount : IDiscount
    {
        private double amount;

        public FixedDiscount(double amount)
        {
            this.amount = amount;
        }

        public double ApplyDiscount(double price)
        {
            return Math.Max(0, price - amount);
        }
    }
}
