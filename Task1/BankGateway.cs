using System;

public class BankGateway
{
	public bool ChargeCard(long cardNumber, decimal amount)
	{
        Console.WriteLine($"Connecting to Bank Gateway...");
        Console.WriteLine($"Charging card {cardNumber} for amount: {amount}...");
    }
}
