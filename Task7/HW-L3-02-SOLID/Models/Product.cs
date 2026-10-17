using System;
using System.Collections.Generic;
using System.Text;


namespace HW_L3_02_SOLID.Models
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
