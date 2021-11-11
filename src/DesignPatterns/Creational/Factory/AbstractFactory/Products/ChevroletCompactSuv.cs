using DesignPatterns.Creational.Factory.AbstractFactory.AbstractProducts;
using System;

namespace DesignPatterns.Creational.Factory.AbstractFactory.Products
{
    public class ChevroletCompactSuv : ISuv
    {
        public string Name()
        {
            return "Chevrolet Trailblazer";
        }
    }
}
