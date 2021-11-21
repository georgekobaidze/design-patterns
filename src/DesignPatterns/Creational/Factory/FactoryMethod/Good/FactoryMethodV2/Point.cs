namespace DesignPatterns.Creational.Factory.FactoryMethod.Good.FactoryMethodV2;

public class Point
{
    private double _x;
    private double _y;

    public Point(double x, double y)
    {
        _x = x;
        _y = y;
    }

    // Print
    public override string ToString() => $"Coordinates: ({_x}, {_y})";
}
