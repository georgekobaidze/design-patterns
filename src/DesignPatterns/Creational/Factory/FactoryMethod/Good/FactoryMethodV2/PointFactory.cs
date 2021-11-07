﻿using System;

namespace DesignPatterns.Creational.Factory.FactoryMethod.Good.FactoryMethodV2
{
    public class PointFactory
    {
        public static Point NewCartesianPoint(double x, double y) => new Point(x, y);
        public static Point NewPolarPoint(double rho, double theta) => new Point(rho * Math.Cos(theta), rho * Math.Sin(theta));
    }
}
