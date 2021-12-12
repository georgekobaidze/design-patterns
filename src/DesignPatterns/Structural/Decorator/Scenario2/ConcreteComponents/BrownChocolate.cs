using DesignPatterns.Structural.Decorator.Scenario2.Components;

namespace DesignPatterns.Structural.Decorator.Scenario2.ConcreteComponents;

public class BrownChocolate : Chocolate
{
    public BrownChocolate()
    {
        Name = "Brown";
        Cost = 12;
    }

    public override string GetInfo() => $"{base.GetInfo()}";
}
