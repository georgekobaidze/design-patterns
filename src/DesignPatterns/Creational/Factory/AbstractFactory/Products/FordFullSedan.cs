using DesignPatterns.Creational.Factory.AbstractFactory.AbstractProducts;

namespace DesignPatterns.Creational.Factory.AbstractFactory.Products
{
    public class FordFullSedan : ISedan
    {
        public string Name()
        {
            return "Ford Fusion";
        }
    }
}
