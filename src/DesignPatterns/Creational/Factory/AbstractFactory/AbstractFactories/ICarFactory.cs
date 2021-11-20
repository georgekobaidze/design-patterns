using DesignPatterns.Creational.Factory.AbstractFactory.AbstractProducts;
using DesignPatterns.Creational.Factory.AbstractFactory.Enums;

namespace DesignPatterns.Creational.Factory.AbstractFactory.AbstractFactories;

// Abstract factory
public interface ICarFactory
{
    ISedan ManufactureSedan(Segment segment);
    ISuv ManufactureSuv(Segment segment);
}
