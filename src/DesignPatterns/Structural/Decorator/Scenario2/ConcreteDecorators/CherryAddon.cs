using DesignPatterns.Structural.Decorator.Scenario2.Components;
using DesignPatterns.Structural.Decorator.Scenario2.Decorators;

namespace DesignPatterns.Structural.Decorator.Scenario2.ConcreteDecorators;

public class CherryAddon : ChocolateDecorator
{
    private readonly decimal _cost;

    public CherryAddon(Chocolate wrappee)
        : base(wrappee) => _cost = 5;

    public override decimal GetTotalCost() => Wrappee.Cost + _cost;

    public override string GetInfo() => $"{base.GetInfo()}\nAdditions:\nCherry: {_cost}$\nTotal cost: {GetTotalCost()}$";
}
