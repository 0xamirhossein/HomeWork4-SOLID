using System;
//


//غلط
public interface IWorker()
{
	public void Eat { get; set;}
	public void Sleep { get; set; }
    // یک اینترفیس IWorker
	/*
	 * وقتی برای ان دو پراپرتی  غذا خوردن و استراحت بگذاریم در صورتی که 
	 * به طور مثال کارگر هر دو این ویژگی ها را دارد 
	 * و ربات غذا خوردن ندارد  به 
	 * Notimplememntedexception برخورد میکنیم 
	 *  و برای پیاده سازی به اینترفیس های کوچیک تر تقسیم میکنند 
	 */
}


public class Worker : IWorker
{

}

public class Robot : IWorker
{
	throw new NotImplementedException("Robot cant eat)
}


// درست

public interface IEatable()
{
    // bla bla bla
}
public interface IWorkable()
{
    // bla bla bla
}


public class Robot : IWorkable , IEatable
{
	throw new NotImplementedException("Robot cant eat)
}
public class Robot : IWorkaable
{
	throw new NotImplementedException("Robot cant eat)
}

