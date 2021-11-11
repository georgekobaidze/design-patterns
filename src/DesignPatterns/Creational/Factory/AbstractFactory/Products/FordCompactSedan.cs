using DesignPatterns.Creational.Factory.AbstractFactory.AbstractProducts;

namespace DesignPatterns.Creational.Factory.AbstractFactory.Products
{
    public class FordCompactSedan : ISedan
    {
        public string Name()
        {
            return "Ford Focus";
        }
    }
}
