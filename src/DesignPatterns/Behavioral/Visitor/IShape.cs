namespace DesignPatterns.Behavioral.Visitor;

public interface IShape
{
    void Accept(IShapeVisitor visitor);
}
