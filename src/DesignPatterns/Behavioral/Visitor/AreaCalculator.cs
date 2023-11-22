using System;
using DesignPatterns.Behavioral.Visitor.ConcreteElements;

namespace DesignPatterns.Behavioral.Visitor;

public class AreaCalculator : IShapeVisitor
{
    public void Visit(Circle circle)
    {
        var area = Math.PI * Math.Pow(circle.Radius, 2);
        Console.WriteLine($"Area of the circle: {area}");
    }

    public void Visit(Rectangle rectangle)
    {
        double area = rectangle.Width * rectangle.Height;
        Console.WriteLine($"Area of the rectangle: {area}");
    }

    public void Visit(Triangle triangle)
    {
        // Assuming it's an equilateral triangle for simplicity
        double area = (Math.Pow(triangle.Side, 2) * Math.Sqrt(3)) / 4;
        Console.WriteLine($"Area of the triangle: {area}");
    }
}
