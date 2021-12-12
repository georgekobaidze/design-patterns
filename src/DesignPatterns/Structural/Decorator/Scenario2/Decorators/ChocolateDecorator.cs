using DesignPatterns.Structural.Decorator.Scenario2.Components;

namespace DesignPatterns.Structural.Decorator.Scenario2.Decorators;

public abstract class ChocolateDecorator : Chocolate
{
    protected Chocolate Wrappee;

    public ChocolateDecorator(Chocolate wrappee)
    {
        Wrappee = wrappee;
    }

    public abstract decimal GetTotalCost();

    public override string GetInfo() => $"{Wrappee.GetInfo()}";
}
