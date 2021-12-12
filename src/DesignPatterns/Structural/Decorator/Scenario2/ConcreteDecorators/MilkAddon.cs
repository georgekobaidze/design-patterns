using DesignPatterns.Structural.Decorator.Scenario2.Components;
using DesignPatterns.Structural.Decorator.Scenario2.Decorators;

namespace DesignPatterns.Structural.Decorator.Scenario2.ConcreteDecorators;

internal class MilkAddon : ChocolateDecorator
{
    private readonly decimal _cost;
    private readonly decimal _milkPercentage;

    public MilkAddon(Chocolate wrappee)
        : base(wrappee)
    {
        _cost = 0.5m;
        _milkPercentage = 12;
    }
    
    public override decimal GetTotalCost() => Wrappee.Cost + _cost;

    public override string GetInfo() => $"{base.GetInfo()}\nAdditions:\nMilk ({_milkPercentage}%): {_cost}$\nTotal cost: {GetTotalCost()}$";
}
