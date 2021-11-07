using DesignPatterns.Creational.Builder.Classic.Bad;
using DesignPatterns.Creational.Builder.Classic.Good;
using DesignPatterns.Creational.Builder.Faceted;
using DesignPatterns.Creational.Builder.Faceted.Builders;
using DesignPatterns.Creational.Builder.Stepwise;
using DesignPatterns.Creational.Factory.AbstractFactory;
using DesignPatterns.Creational.Factory.AbstractFactory.ConcreteFactories;
using DesignPatterns.Creational.Factory.AbstractFactory.Enums;
using DesignPatterns.Creational.Factory.FactoryMethod.Bad;
using DesignPatterns.Creational.Factory.FactoryMethod.Good.FactoryMethodV2;
using DesignPatterns.Solid.LiskovSubstitution;
using DesignPatterns.Solid.OpenClosed;
using DesignPatterns.Solid.OpenClosed.Enums;
using DesignPatterns.Solid.OpenClosed.Filters.Bad;
using DesignPatterns.Solid.OpenClosed.Filters.Good;
using DesignPatterns.Solid.OpenClosed.Filters.Good.Specifications;
using DesignPatterns.Solid.SingleResponsibility;
using System;
using System.Collections.Generic;

using BadFactoryMethod = DesignPatterns.Creational.Factory.FactoryMethod.Bad;
using GoodFactoryMethodV1 = DesignPatterns.Creational.Factory.FactoryMethod.Good.FactoryMethodV1;
using GoodFactoryMethodV3 = DesignPatterns.Creational.Factory.FactoryMethod.Good.FactoryMethodV3;

namespace DesignPatterns
{
    class Program
    {
        static void Main()
        {
            #region Single Responsibility

            var shoppingCart = new ShoppingCart();

            shoppingCart.Add(new ShoppingItem { Id = 123, Name = "Keyboard", Price = 450 });
            shoppingCart.Add(new ShoppingItem { Id = 124, Name = "Mouse", Price = 300 });
            shoppingCart.Add(new ShoppingItem { Id = 125, Name = "Monitor", Price = 2200 });

            var utils = new InvoiceUtility();
            utils.SaveToFile(shoppingCart, "C:\\Users\\Giorgi\\Desktop\\Invoice.txt", true);

            #endregion

            #region Open-Closed

            var vehiclesAtDealership = new List<Vehicle>
            {
                new Vehicle(Brand.Ford, VehicleType.SUV, Color.Blue, 2.5m),
                new Vehicle(Brand.Toyota, VehicleType.Sedan, Color.White, 2m),
                new Vehicle(Brand.Nissan, VehicleType.Sedan, Color.Red, 1.6m),
                new Vehicle(Brand.Dodge, VehicleType.Pickup, Color.Black, 5.5m),
                new Vehicle(Brand.Ford, VehicleType.Crossover, Color.Orange, 0),
                new Vehicle(Brand.Chevrolet, VehicleType.Truck, Color.Purple, 7.5m)
            };

            // BAD PRACTICE ALERT:
            var badFilter = new BadVehicleFilter();

            // First let's filter it by brand
            var filteredVehiclesByBrand = badFilter.FilterByBrand(vehiclesAtDealership, Brand.Ford);
            foreach (var vehicle in filteredVehiclesByBrand)
                Console.WriteLine(vehicle.Brand.ToString());

            // When we need to filter by other properties, we need to modify our filter and add yet another method:
            var filteredVehiclesByColor = badFilter.FilterByColor(vehiclesAtDealership, Color.Black);
            foreach (var vehicle in filteredVehiclesByColor)
                Console.WriteLine(vehicle.Brand.ToString());

            // This will apply to any other property

            //Now let's use the specification pattern:
            var goodFilter = new GoodFilter();
            var filteredVehicles = goodFilter.Filter(vehiclesAtDealership, new ColorSpecification(Color.Blue));
            foreach (var vehicle in filteredVehicles)
                Console.WriteLine(vehicle.Brand.ToString());

            // Multiple Specifications:
            var filteredVehiclesByColorAndBrand = goodFilter.Filter(
                vehiclesAtDealership,
                new AndSpecification<Vehicle>(
                    new ColorSpecification(Color.Purple),
                    new BrandSpecification(Brand.Chevrolet)));

            foreach (var vehicle in filteredVehiclesByColorAndBrand)
                Console.WriteLine(vehicle.Brand.ToString());

            #endregion

            #region Liskov Substitution
            var rectangle = new Rectangle(5, 2);
            Console.WriteLine(rectangle);

            Rectangle square = new Square(); // It should work without any side effects, but it won't.
            square.Width = 4;

            Console.WriteLine(square);

            //To fix this, we can make rectangle properties virtual and override them in a square class.
            #endregion

            #region Builder

            #region Classic
            var nissan = new BadCarBuilder()
                .SetMake("Nissan")
                .SetModel("Juke")
                .SetManufactureDate("04/06/2015")
                .Build();

            Console.WriteLine(nissan);

            var builder = new CarBuilder();
            var ford = new FordEscapeBuilder(builder).Build();
            Console.WriteLine(ford);
            #endregion

            #region Stepwise
            var airplane = AirplaneBuilder
                .Create()
                .OfType(AirplaneType.Public)
                .WithSeatsNumber(150)
                .Build();

            Console.WriteLine(airplane);
            #endregion

            #region Facade
            Person personBuilder = new PersonBuilder()
                .Works
                    .At("Amazon")
                    .AsA("Software Engineer")
                    .Earning(120000)
                .Lives
                    .At("Pike Street")
                    .WithPostalCode("5571")
                    .In("Seattle");

            Console.WriteLine(personBuilder);

            // The only side effect here is that method execution sequance isn't logically restricted
            // So we can write something like:
            //var pb = new PersonBuilder().Lives.Lives.Works.Works;


            #endregion

            #endregion

            #region Factory
            #region Factory Method

            // BAD PRACTICE ALERT!
            var badPoint1 = new BadFactoryMethod.Point(2, 5, CoordinateSystem.Cartesian);
            var badPoint2 = new BadFactoryMethod.Point(15, Math.PI / 6, CoordinateSystem.Polar);

            // Now with the factory method:
            var point1 = GoodFactoryMethodV1.Point.NewCartesianPoint(2, 5);
            var point2 = GoodFactoryMethodV1.Point.NewPolarPoint(15, Math.PI / 6);
            Console.WriteLine(point1);
            Console.WriteLine(point2);

            // Improvement with a separate factory:
            var point3 = PointFactory.NewCartesianPoint(2, 5);
            var point4 = PointFactory.NewPolarPoint(15, Math.PI / 6);
            Console.WriteLine(point3);
            Console.WriteLine(point4);
            // This approach has the only caviat, we need to make the constructor of Point class public

            // Further improvement using inner factory:
            var point5 = GoodFactoryMethodV3.Point.Factory.NewCartesianPoint(2, 5);
            var point6 = GoodFactoryMethodV3.Point.Factory.NewPolarPoint(15, Math.PI / 6);
            Console.WriteLine(point5);
            Console.WriteLine(point6);

            #endregion

            #region Abstract Factory
            var fordClient = new CarClient(new FordFactory(), Segment.Full);
            var chevroletClient = new CarClient(new ChevroletFactory(), Segment.Compact);

            var fordName = fordClient.GetSuvName();
            var chevroletName = chevroletClient.GetSuvName();

            Console.WriteLine($"Manufactured cars are:\n{fordName}\n{chevroletName}");

            #endregion

            #endregion
        }
    }
}
