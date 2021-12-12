namespace DesignPatterns.Structural.Decorator.Scenario2.Components;

public abstract class Chocolate
{
    protected string Name;
    public decimal Cost;

    public virtual string GetInfo() => $"Name: {Name}\nCost: {Cost}$";
}
