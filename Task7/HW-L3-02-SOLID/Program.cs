
using System;
using HW_L3_02_SOLID.Discounts;
using HW_L3_02_SOLID.Interfaces;
using HW_L3_02_SOLID.Models;
using HW_L3_02_SOLID.Services;

namespace HW_L3_02_SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("Laptop", 30000000);

            // انتخاب تخفیف درصدی
            IDiscount discount = new PercentageDiscount(10);

            // برای تخفیف مبلغ ثابت، خط بالا را با این خط جایگزین کن:
            // IDiscount discount = new FixedDiscount(2000000);

            IEmailService emailService = new EmailService();

            Order order = new Order(discount, emailService);

            order.Buy(product, "customer@example.com");

            Console.ReadKey();
        }
    }
}
