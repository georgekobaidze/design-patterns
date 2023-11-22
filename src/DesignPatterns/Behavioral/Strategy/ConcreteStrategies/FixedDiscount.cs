using System;

namespace DesignPatterns.Behavioral.Strategy.ConcreteStrategies;

public class FixedDiscount : IDiscountStrategy
{
    private readonly decimal _discountAmount;

    public FixedDiscount(decimal discountAmount)
    {
        _discountAmount = discountAmount;
    }
    
    public decimal ApplyDiscount(decimal amount)
    {
        if (_discountAmount > amount)
            throw new ArgumentException("Discount amount can't be greater than the actual price.");
        
        return amount - _discountAmount;
    }
}
