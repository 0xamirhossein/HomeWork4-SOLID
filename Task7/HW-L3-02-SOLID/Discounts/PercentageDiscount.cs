using System;
using System.Collections.Generic;
using System.Text;


using HW_L3_02_SOLID.Interfaces;

namespace HW_L3_02_SOLID.Discounts
{
    internal class PercentageDiscount : IDiscount
    {
        private double percentage;

        public PercentageDiscount(double percentage)
        {
            this.percentage = percentage;
        }

        public double ApplyDiscount(double price)
        {
            return price - (price * percentage / 100);
        }
    }
}
