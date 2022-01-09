namespace DesignPatterns.Structural.Composite.Component;

public abstract class Gift
{
    protected string Name;
    protected decimal Price;

    public Gift(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public abstract decimal CalculateTotalCost();
}
