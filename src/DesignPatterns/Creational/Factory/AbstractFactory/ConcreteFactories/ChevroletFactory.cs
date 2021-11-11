using DesignPatterns.Creational.Factory.AbstractFactory.AbstractFactories;
using DesignPatterns.Creational.Factory.AbstractFactory.AbstractProducts;
using DesignPatterns.Creational.Factory.AbstractFactory.Enums;
using DesignPatterns.Creational.Factory.AbstractFactory.Products;
using System;

namespace DesignPatterns.Creational.Factory.AbstractFactory.ConcreteFactories
{
    public class ChevroletFactory : ICarFactory
    {
        public ISedan ManufactureSedan(Segment segment)
        {
            switch (segment)
            {
                case Segment.Full:
                    return new ChevroletFullSedan();
                case Segment.Compact:
                    return null;
                default:
                    throw new Exception("Unknown segment type");
            }
        }

        public ISuv ManufactureSuv(Segment segment)
        {
            switch (segment)
            {
                case Segment.Full:
                    return null;
                case Segment.Compact:
                    return new ChevroletCompactSuv();
                default:
                    throw new Exception("Unknown segment type");
            }
        }
    }
}
