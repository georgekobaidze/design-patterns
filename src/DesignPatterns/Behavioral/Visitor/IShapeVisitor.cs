using DesignPatterns.Behavioral.Visitor.ConcreteElements;

namespace DesignPatterns.Behavioral.Visitor;

// Visitor interface
public interface IShapeVisitor
{
    void Visit(Circle circle);
    void Visit(Rectangle rectangle);
    void Visit(Triangle triangle);
}
