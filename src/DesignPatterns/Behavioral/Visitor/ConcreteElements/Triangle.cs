namespace DesignPatterns.Behavioral.Visitor.ConcreteElements;

public class Triangle : IShape
{
    public double Side { get; }

    public Triangle(double side)
    {
        Side = side;
    }

    public void Accept(IShapeVisitor visitor)
    {
        visitor.Visit(this);
    }
}
