using DesignPatterns.Creational.Factory.AbstractFactory.AbstractProducts;

namespace DesignPatterns.Creational.Factory.AbstractFactory.Products;

public class FordFullSuv : ISuv
{
    public string Name() => "Ford Escape";
}
