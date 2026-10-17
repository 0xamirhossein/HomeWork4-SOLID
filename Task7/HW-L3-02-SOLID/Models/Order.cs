using System;
using System.Collections.Generic;
using System.Text;


using System;
using HW_L3_02_SOLID.Interfaces;

namespace HW_L3_02_SOLID.Models
{
    internal class Order
    {
        private readonly IDiscount discount;
        private readonly IEmailService emailService;

        public Order(IDiscount discount, IEmailService emailService)
        {
            this.discount = discount;
            this.emailService = emailService;
        }

        public void Buy(Product product, string customerEmail)
        {
            double finalPrice = discount.ApplyDiscount(product.Price);

            Console.WriteLine($"product name : {product.Name}");
            Console.WriteLine($"product price: {product.Price}");
            Console.WriteLine($"final price: {finalPrice}");

            emailService.SendEmail(
                customerEmail,
                $"kharid mahsool {product.Name} ba mablagh  {finalPrice} ba movafaghiat anjam shod."
            );
        }
    }
}
