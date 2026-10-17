using System;

public abstract class Bird
{
    public void Eat()
    {
        Console.WriteLine("Bird is eating...");
    }
}

public interface IFlyable
{
    void Fly();
}

public class Eagle : Bird, IFlyable
{
    public void Fly()
    {
        Console.WriteLine("Eagle is flying");
    }
}

public class Penguin : Bird
{

    public void Swim()
    {
        Console.WriteLine("Penguin is swimming!");
    }
}