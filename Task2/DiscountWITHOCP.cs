using System;

public class Discount
{
	public interface IDiscount 
	{ 
		decimal DiscountPercent(decimal amount);
	}
    

    public class VipDiscount : IDiscount
    {
        public decimal Calculate(decimal amount)
        {
            return amount * 0.2m;
        }
    }

    public class RegularDiscount : IDiscount
    {
        public decimal Calculate(decimal amount)
        {
            return amount * 0.1m;
        }
    }


    // main code 
}
