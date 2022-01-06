using System;
using DesignPatterns.Structural.Decorator.Scenario1.Good.Interfaces;

namespace DesignPatterns.Structural.Decorator.Scenario1.Good.Classes;

public class God : IGod
{
    public int Power { get; set; }

    public void LightningStrike() => Console.WriteLine($"Lightning strike with a damage of {Power}");
}
