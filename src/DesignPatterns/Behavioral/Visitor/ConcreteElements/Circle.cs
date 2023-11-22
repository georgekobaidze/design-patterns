namespace DesignPatterns.Behavioral.Visitor.ConcreteElements;

public class Circle : IShape
{
    public double Radius { get; }
    
    
    public Circle(double radius)
    {
        Radius = radius;
    }

    public void Accept(IShapeVisitor visitor)
    {
        visitor.Visit(this);
    }
}
