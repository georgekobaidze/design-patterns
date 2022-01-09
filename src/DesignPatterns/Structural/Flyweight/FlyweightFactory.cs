using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Structural.Flyweight;

public class FlyweightFactory
{
    private List<Tuple<string, Flyweight>> _flyWeights = new();

    public FlyweightFactory(params Soldier[] args)
    {
        foreach (var item in args)
            _flyWeights.Add(new Tuple<string, Flyweight>(item.GetHash(), new Flyweight(item)));
    }

    public Flyweight GetFlyweight(Soldier sharedState)
    {
        var key = sharedState.GetHash();

        var existingFlyWeight = _flyWeights.FirstOrDefault(x => x.Item1 == key);
        if (existingFlyWeight == null)
        {
            Console.WriteLine("Existing flyweight not found, creating a new one.");
            var newFlyWeight = new Flyweight(sharedState);
            _flyWeights.Add(new Tuple<string, Flyweight>(key, newFlyWeight));
            return newFlyWeight;
        }
        else
        {
            Console.WriteLine("Existing flyweight found, which can be reused");
            return existingFlyWeight.Item2;
        }
    }

    public void ListAllFlyweights()
    {
        Console.WriteLine($"Found {_flyWeights.Count} flyweights");
        foreach (var item in _flyWeights)
            Console.WriteLine(item.Item1);
    }

    public void AddNewObject(Soldier soldier)
    {
        var flyweight = GetFlyweight(new Soldier(soldier.Race, soldier.Specialization));
        flyweight.Operation(soldier);
    }
}
