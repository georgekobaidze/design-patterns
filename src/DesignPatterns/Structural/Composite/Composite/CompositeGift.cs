using System;
using System.Collections.Generic;
using System.Linq;
using DesignPatterns.Structural.Composite.Component;

namespace DesignPatterns.Structural.Composite.Composite;

public class CompositeGift : Gift, IGiftOperations
{
    private List<Gift> _gifts;

    public CompositeGift(string name, decimal price)
        : base(name, price) => _gifts = new List<Gift>();

    public void AddGift(Gift gift) => _gifts.Add(gift);
    public void RemoveGift(Gift gift) => _gifts.Remove(gift);

    public override decimal CalculateTotalCost()
    {
        Console.WriteLine($"{Name} (price: {Price}) contains the following items:");
        var sum = Price + _gifts.Sum(x => x.CalculateTotalCost());

        return sum;
    }
}
