namespace DesignPatterns.Behavioral.Strategy.ConcreteStrategies;

public class NoDiscount : IDiscountStrategy
{
    public decimal ApplyDiscount(decimal amount)
    {
        return amount;
    }
}
