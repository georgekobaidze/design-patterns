using DesignPatterns.Creational.Factory.AbstractFactory.AbstractFactories;
using DesignPatterns.Creational.Factory.AbstractFactory.AbstractProducts;
using DesignPatterns.Creational.Factory.AbstractFactory.Enums;
using DesignPatterns.Creational.Factory.AbstractFactory.Products;
using System;

namespace DesignPatterns.Creational.Factory.AbstractFactory.ConcreteFactories
{
    public class FordFactory : ICarFactory
    {
        public ISedan ManufactureSedan(Segment segment)
        {
            switch (segment)
            {
                case Segment.Compact:
                    return new FordCompactSedan();
                case Segment.Full:
                    return new FordFullSedan();
                default:
                    throw new Exception("Unknown segment type");
            }
        }

        public ISuv ManufactureSuv(Segment segment)
        {
            switch (segment)
            {
                case Segment.Full:
                    return new FordFullSuv();
                case Segment.Compact:
                    return null;
                default:
                    throw new Exception("Unknown segment type");
            }
        }
    }
}
