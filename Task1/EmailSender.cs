using System;

public class EmailSender
{
    public void SendReceipt(string email, decimal amount)
    {
        Console.WriteLine($"Sending payment receipt email to {email} for amount {amount}...");
    }
}
