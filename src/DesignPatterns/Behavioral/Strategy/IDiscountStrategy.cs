namespace DesignPatterns.Behavioral.Strategy;

public interface IDiscountStrategy
{
    decimal ApplyDiscount(decimal amount);
}
