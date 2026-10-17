using System;

public class PaymentProcessor
{
    public void ProcessPayment(string cardNumber, decimal amount, string userEmail)
    {
        Console.WriteLine($"Connecting to Bank Gateway...");
        Console.WriteLine($"Charging card {cardNumber} for amount: {amount}...");
        bool isSuccess = true; 

        if (!isSuccess)
        {
            throw new Exception("Payment failed.");
        }

        File.AppendAllText("transaction_logs.txt", $"Card {cardNumber} paid {amount} at {DateTime.Now}\n");

        Console.WriteLine($"Sending payment receipt email to {userEmail}...");


        // SRP رعایت نشده چون هر کلاس فقط باید یک دغدغه داشته باشد  در حالی که اینجا ارسال ایمیل ذخیره در دیتابیس 
        // و اتصال به بانک در قالب یک کلا است 
        // و باید سه کلاس جدا شوند بعلاوه یک کلاس که مدیریت این هارو بر عهده داره  انجام بده 
    }
}