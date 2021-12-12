using DesignPatterns.Structural.Decorator.Scenario2.Components;
using DesignPatterns.Structural.Decorator.Scenario2.Decorators;

namespace DesignPatterns.Structural.Decorator.Scenario2.ConcreteDecorators;

public class NutAddon : ChocolateDecorator
{
    private readonly decimal _cost;

    public NutAddon(Chocolate wrappee)
        : base(wrappee) => _cost = 1;

    public override decimal GetTotalCost() => Wrappee.Cost + _cost;

    public override string GetInfo() => $"{base.GetInfo()}\nAdditions:\nNut: {_cost}$\nTotal cost: {GetTotalCost()}$";
}
