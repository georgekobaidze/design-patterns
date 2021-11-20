using System;
using DesignPatterns.Creational.Factory.AbstractFactory.AbstractFactories;
using DesignPatterns.Creational.Factory.AbstractFactory.AbstractProducts;
using DesignPatterns.Creational.Factory.AbstractFactory.Enums;
using DesignPatterns.Creational.Factory.AbstractFactory.Products;

namespace DesignPatterns.Creational.Factory.AbstractFactory.ConcreteFactories;

public class FordFactory : ICarFactory
{
    public ISedan ManufactureSedan(Segment segment) => segment switch
    {
        Segment.Compact => new FordCompactSedan(),
        Segment.Full => new FordFullSedan(),
        _ => throw new Exception("Unknown segment type"),
    };

    public ISuv ManufactureSuv(Segment segment) => segment switch
    {
        Segment.Full => new FordFullSuv(),
        Segment.Compact => null,
        _ => throw new Exception("Unknown segment type"),
    };
}
