namespace DesignPatterns.Behavioral.Strategy;

public class ShoppingCart
{
    private IDiscountStrategy _discountStrategy;

    public void SetDiscountStrategy(IDiscountStrategy discountStrategy)
    {
        this._discountStrategy = discountStrategy;
    }

    public decimal CalculateTotal(decimal originalAmount)
    {
        return _discountStrategy.ApplyDiscount(originalAmount);
    }
}
