using System;
using System.Collections.Generic;
using System.Text;


namespace HW_L3_02_SOLID.Interfaces
{
    internal interface IEmailService
    {
        void SendEmail(string email, string message);
    }
}

