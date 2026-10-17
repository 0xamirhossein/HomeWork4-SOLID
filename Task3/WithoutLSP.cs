using System;

public class Bird
{
	public virtual void Fly()
	{
		Console.WriteLine("Bird can fly ")
		
	}
	// مصل مثالی ک استاد فرمودند پنگوین نوعی پرنده نیست اما در کلاس پرنده بگذاریم نمیتواند پرواز کند و مجبوریم در متود کلاس فرزند OVERRIDE کنیم 
}
public class Penguin : Bird
{
	public override void Fly()
	{
		Console.Writeline("penguin cannot fly")
	}
}
