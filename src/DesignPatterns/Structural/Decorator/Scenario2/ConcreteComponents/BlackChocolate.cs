using DesignPatterns.Structural.Decorator.Scenario2.Components;

namespace DesignPatterns.Structural.Decorator.Scenario2.ConcreteComponents;

public class BlackChocolate : Chocolate
{
    public BlackChocolate()
    {
        Name = "Black";
        Cost = 15;
    }

    public override string GetInfo() => $"{base.GetInfo()}";
}
