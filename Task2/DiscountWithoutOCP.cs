using System;

public class Discount
{
	public decimal DiscountPercent(string customertype, decimal amount)
	{
		if (customertype == "vip")
		{
			return amount*0.2m;
		}
		else if (customertype =="regular")
		{
			return amount * 0.1m;
		}
	}
	//باز بودن به گسترش و بسته بودن به تغییرات یکمی ازمتود ها استفاده از interface است 
}
