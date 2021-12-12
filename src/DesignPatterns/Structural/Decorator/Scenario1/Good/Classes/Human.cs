using System;
using DesignPatterns.Structural.Decorator.Scenario1.Good.Interfaces;

namespace DesignPatterns.Structural.Decorator.Scenario1.Good.Classes;

public class Human : IHuman
{
    public int Power { get; set; }

    public void Punch() => Console.WriteLine($"Punch with a damage of {Power}");
}
