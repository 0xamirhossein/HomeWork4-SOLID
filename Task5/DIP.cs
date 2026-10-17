using System;
//


//اشتباه 
public class GmailService
{
    public void Send()
    {
        // send email 
    }
}

public class UserManager
{
    private GmailService _gmailService;

    public UserManager()
    {
        _gmailService = new GmailService();
    }

}
/*
 * ماژول سطح بالا نباید به مازول سطح پایین وابسته باشند بلکه از طریق مکانیزمی 
 *  با هم ارتباط بگیرند
 * برای این کار باید انتزاع  IMessageService
 *  را تعریف کرد و با پیاده سازی مازول سطح پایین از اینترفیس 
 *  و تزریق اینتر فییس به کلاس سازنده وابستگی را کم کرد 
*/
//



// درست 



public interface IMessageService
{
    void SendMessage(string message);
}



public class GmailService : IMessageService
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"Sending Gmail: {message}");
    }
}


public class SmsService : IMessageService
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"Sending SMS: {message}");
    }
}


public class UserManager
{
    private readonly IMessageService _messageService;

    public UserManager(IMessageService messageService)
    {
        _messageService = messageService;
    }

    public void RegisterUser(string username)
    {
        Console.WriteLine($"User {username} registered successfully.");
        _messageService.SendMessage($"Welcome {username}!");
    }
}