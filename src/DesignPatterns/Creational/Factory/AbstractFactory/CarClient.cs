using DesignPatterns.Creational.Factory.AbstractFactory.AbstractFactories;
using DesignPatterns.Creational.Factory.AbstractFactory.AbstractProducts;
using DesignPatterns.Creational.Factory.AbstractFactory.Enums;

namespace DesignPatterns.Creational.Factory.AbstractFactory;

public class CarClient
{
    private ISedan _sedan;
    private ISuv _suv;

    public CarClient(ICarFactory factory, Segment segment)
    {
        _sedan = factory.ManufactureSedan(segment);
        _suv = factory.ManufactureSuv(segment);
    }

    public string GetSedanName() => _sedan?.Name();
    public string GetSuvName() => _suv?.Name();
}
