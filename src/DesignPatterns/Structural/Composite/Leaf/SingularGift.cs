using System;
using DesignPatterns.Structural.Composite.Component;

namespace DesignPatterns.Structural.Composite.Leaf;

public class SingularGift : Gift
{
    public SingularGift(string name, decimal price) 
        : base(name, price)
    {
    }

    public override decimal CalculateTotalCost()
    {
        Console.WriteLine($"{Name} with price {Price}");
        return Price;
    }
}
