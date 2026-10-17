using System;
using System.Collections.Generic;
using System.Text;


using System;
using HW_L3_02_SOLID.Interfaces;

namespace HW_L3_02_SOLID.Services
{
    internal class EmailService : IEmailService
    {
        public void SendEmail(string email, string message)
        {
            Console.WriteLine("sending email...");
            Console.WriteLine($"sender: {email}");
            Console.WriteLine($"message: {message}");
        }
    }
}
