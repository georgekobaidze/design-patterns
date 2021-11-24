using System;

namespace DesignPatterns.Creational.Factory.FactoryMethod.Bad;

public class Point
{
    private double _x;
    private double _y;

    // We can't have two constructors for each case (cartesian or polar)
    //public Point(double x, double y)
    //{
    //    _x = x;
    //    _y = y;
    //}

    //public Point(double rho, double theta)
    //{
    //    _x = rho * Math.Cos(theta);
    //    _y = rho * Math.Sin(theta);
    //}

    // So instead we should do something like below (and again BAD PRACTICE ALERT!):


    /// <summary>
    /// Initializes a point (cartesian or polar)
    /// </summary>
    /// <param name="a">X if cartesian, rho if polar</param>
    /// <param name="b">Y if cartesian, theta if polar</param>
    /// <param name="system">Coordinate system</param>
    public Point(double a, double b, CoordinateSystem system = CoordinateSystem.Cartesian)
    {
        switch (system)
        {
            case CoordinateSystem.Cartesian:
                _x = a;
                _y = b;
                break;
            case CoordinateSystem.Polar:
                _x = a * Math.Cos(b);
                _y = a * Math.Sin(b);
                break;
            default:
                throw new ArgumentException("Invalid coordinate system");
        }
    }
}

// This is needed to differenciate coordinate systems
public enum CoordinateSystem
{
    Cartesian,
    Polar
}
