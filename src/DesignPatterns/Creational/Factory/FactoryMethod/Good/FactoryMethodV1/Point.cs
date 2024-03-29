﻿using System;

namespace DesignPatterns.Creational.Factory.FactoryMethod.Good.FactoryMethodV1;

public class Point
{
    private double _x;
    private double _y;

    // This constructor is no longer available to initialize an object directly with it
    private Point(double x, double y)
    {
        _x = x;
        _y = y;
    }

    // Factory methods:
    public static Point NewCartesianPoint(double x, double y) => new(x, y);
    public static Point NewPolarPoint(double rho, double theta) => new(rho * Math.Cos(theta), rho * Math.Sin(theta));

    // Print
    public override string ToString() => $"Coordinates: ({_x}, {_y})";
}
