using System;

namespace DesignPatterns.Behavioral.Strategy.ConcreteStrategies;

public class PercentageDiscount : IDiscountStrategy
{
    private readonly decimal _percentage;

    public PercentageDiscount(decimal percentage)
    {
        if (percentage > 100 && percentage < 0)
            throw new ArgumentException("Invalid percentage");
        
        _percentage = percentage;
    }
    
    public decimal ApplyDiscount(decimal amount)
    {
        return amount * (1 - _percentage / 100);
    }
}
