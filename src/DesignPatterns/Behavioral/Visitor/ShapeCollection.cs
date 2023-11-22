using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Visitor;

// Object Structure
public class ShapeCollection
{
    private List<IShape> shapes = new();

    public void AddShape(IShape shape)
    {
        shapes.Add(shape);
    }

    public void AcceptVisitor(IShapeVisitor visitor)
    {
        foreach (var shape in shapes)
        {
            shape.Accept(visitor);
        }
    }
}
