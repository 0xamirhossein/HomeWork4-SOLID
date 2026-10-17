using System;

public class TransactionLogger
{
    public void Log(long cardNumber, decimal amount)
    {
        File.AppendAllText("transaction_logs.txt", $"Card {cardNumber} paid {amount} at {DateTime.Now}\n");
    }
}
