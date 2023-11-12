﻿using System;
using System.Collections.Generic;
using System.IO;
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
using DesignPatterns.Creational.Prototype.Good.Serialization;
using DesignPatterns.Creational.Singleton;
using DesignPatterns.Solid.LiskovSubstitution;
using DesignPatterns.Solid.OpenClosed;
using DesignPatterns.Solid.OpenClosed.Enums;
using DesignPatterns.Solid.OpenClosed.Filters.Good.Specifications;
using DesignPatterns.Solid.SingleResponsibility;
using DesignPatterns.Solid.SingleResponsibility.Good;
using BadFactoryMethod = DesignPatterns.Creational.Factory.FactoryMethod.Bad;
using BadOpenClosed = DesignPatterns.Solid.OpenClosed.Filters.Bad;
using BadPrototype = DesignPatterns.Creational.Prototype.Bad;
using GoodFactoryMethodV1 = DesignPatterns.Creational.Factory.FactoryMethod.Good.FactoryMethodV1;
using GoodFactoryMethodV3 = DesignPatterns.Creational.Factory.FactoryMethod.Good.FactoryMethodV3;
using GoodOpenClosed = DesignPatterns.Solid.OpenClosed.Filters.Good;
using GoodPrototypeCopyConstructors = DesignPatterns.Creational.Prototype.Good.CopyConstructors;
using GoodPrototypeExplicitDeepCopyInterface = DesignPatterns.Creational.Prototype.Good.ExplicitDeepCopyInterface;
using GoodPrototypeSerializer = DesignPatterns.Creational.Prototype.Good.Serialization;
using DesignPatterns.Structural.Adapter;
using QRCoder;
using DesignPatterns.Structural.Facade;
using DesignPatterns.Structural.Proxy;
using DesignPatterns.Structural.Decorator.Scenario2.ConcreteComponents;
using DesignPatterns.Structural.Decorator.Scenario2.ConcreteDecorators;
using DesignPatterns.Structural.Bridge.ConcreteImplementations;
using DesignPatterns.Structural.Bridge.ExtendedAbstractions;
using DesignPatterns.Structural.Composite.Leaf;
using DesignPatterns.Structural.Composite.Composite;
using System.Text;
using DesignPatterns.Behavioral.ChainOfResponsibility;
using DesignPatterns.Behavioral.ChainOfResponsibility.ConcreteApprovers;
using DesignPatterns.Structural.Flyweight;

// #region SOLID
// #region Single Responsibility
//
// var shoppingCart = new ShoppingCart();
//
// shoppingCart.Add(new ShoppingItem { Id = 123, Name = "Keyboard", Price = 450 });
// shoppingCart.Add(new ShoppingItem { Id = 124, Name = "Mouse", Price = 300 });
// shoppingCart.Add(new ShoppingItem { Id = 125, Name = "Monitor", Price = 2200 });
//
// var outputFilePath = Path.GetFullPath(@"..\..\..\..\..\Output.txt");
// var utils = new InvoiceUtility();
// utils.SaveToFile(shoppingCart, outputFilePath, true);
//
// #endregion
//
// #region Open-Closed
//
// var vehiclesAtDealership = new List<Vehicle>
// {
//     new Vehicle(Brand.Ford, VehicleType.SUV, Color.Blue, 2.5m),
//     new Vehicle(Brand.Toyota, VehicleType.Sedan, Color.White, 2m),
//     new Vehicle(Brand.Nissan, VehicleType.Sedan, Color.Red, 1.6m),
//     new Vehicle(Brand.Dodge, VehicleType.Pickup, Color.Black, 5.5m),
//     new Vehicle(Brand.Ford, VehicleType.Crossover, Color.Orange, 0),
//     new Vehicle(Brand.Chevrolet, VehicleType.Truck, Color.Purple, 7.5m)
// };
//
// // BAD PRACTICE ALERT:
// var badFilter = new BadOpenClosed.VehicleFilter();
//
// // First let's filter it by brand
// var filteredVehiclesByBrand = badFilter.FilterByBrand(vehiclesAtDealership, Brand.Ford);
// foreach (var vehicle in filteredVehiclesByBrand)
//     Console.WriteLine(vehicle.Brand.ToString());
//
// // When we need to filter by other properties, we need to modify our filter and add yet another method:
// var filteredVehiclesByColor = badFilter.FilterByColor(vehiclesAtDealership, Color.Black);
// foreach (var vehicle in filteredVehiclesByColor)
//     Console.WriteLine(vehicle.Brand.ToString());
//
// // This will apply to any other property
//
// //Now let's use the specification pattern:
// var goodFilter = new GoodOpenClosed.VehicleFilter();
// var filteredVehicles = goodFilter.Filter(vehiclesAtDealership, new ColorSpecification(Color.Blue));
// foreach (var vehicle in filteredVehicles)
//     Console.WriteLine(vehicle.Brand.ToString());
//
// // Multiple Specifications:
// var filteredVehiclesByColorAndBrand = goodFilter.Filter(
//     vehiclesAtDealership,
//     new AndSpecification<Vehicle>(
//         new ColorSpecification(Color.Purple),
//         new BrandSpecification(Brand.Chevrolet)));
//
// foreach (var vehicle in filteredVehiclesByColorAndBrand)
//     Console.WriteLine(vehicle.Brand.ToString());
//
// #endregion
//
// #region Liskov Substitution
// var rectangle = new Rectangle(5, 2);
// Console.WriteLine(rectangle);
//
// Rectangle square = new Square(); // It should work without any side effects, but it won't.
// square.Width = 4;
//
// Console.WriteLine(square);
//
// //To fix this, we can make rectangle properties virtual and override them in a square class.
// #endregion
//
// #endregion
//
// #region Creational
//
// #region Builder
//
// #region Classic
// var nissan = new BadCarBuilder()
//     .SetMake("Nissan")
//     .SetModel("Juke")
//     .SetManufactureDate("04/06/2015")
//     .Build();
//
// Console.WriteLine(nissan);
//
// var builder = new CarBuilder();
// var ford = new FordEscapeBuilder(builder).Build();
// Console.WriteLine(ford);
// #endregion
//
// #region Stepwise
// var airplane = AirplaneBuilder
//     .Create()
//     .OfType(AirplaneType.Public)
//     .WithSeatsNumber(150)
//     .Build();
//
// Console.WriteLine(airplane);
// #endregion
//
// #region Facade
// Person personBuilder = new PersonBuilder()
//     .Works
//         .At("Amazon")
//         .AsA("Software Engineer")
//         .Earning(120000)
//     .Lives
//         .At("Pike Street")
//         .WithPostalCode("5571")
//         .In("Seattle");
//
// Console.WriteLine(personBuilder);
//
// // The only side effect here is that method execution sequance isn't logically restricted
// // So we can write something like:
// //var pb = new PersonBuilder().Lives.Lives.Works.Works;
//
//
// #endregion
//
// #endregion
//
// #region Factory
// #region Factory Method
//
// // BAD PRACTICE ALERT!
// var badPoint1 = new BadFactoryMethod.Point(2, 5, CoordinateSystem.Cartesian);
// var badPoint2 = new BadFactoryMethod.Point(15, Math.PI / 6, CoordinateSystem.Polar);
//
// // Now with the factory method:
// var point1 = GoodFactoryMethodV1.Point.NewCartesianPoint(2, 5);
// var point2 = GoodFactoryMethodV1.Point.NewPolarPoint(15, Math.PI / 6);
// Console.WriteLine(point1);
// Console.WriteLine(point2);
//
// // Improvement with a separate factory:
// var point3 = PointFactory.NewCartesianPoint(2, 5);
// var point4 = PointFactory.NewPolarPoint(15, Math.PI / 6);
// Console.WriteLine(point3);
// Console.WriteLine(point4);
// // This approach has the only caviat, we need to make the constructor of Point class public
//
// // Further improvement using inner factory:
// var point5 = GoodFactoryMethodV3.Point.Factory.NewCartesianPoint(2, 5);
// var point6 = GoodFactoryMethodV3.Point.Factory.NewPolarPoint(15, Math.PI / 6);
// Console.WriteLine(point5);
// Console.WriteLine(point6);
//
// #endregion
//
// #region Abstract Factory
// var fordClient = new CarClient(new FordFactory(), Segment.Full);
// var chevroletClient = new CarClient(new ChevroletFactory(), Segment.Compact);
//
// var fordName = fordClient.GetSuvName();
// var chevroletName = chevroletClient.GetSuvName();
//
// Console.WriteLine($"Manufactured cars are:\n{fordName}\n{chevroletName}");
//
// #endregion
//
// #endregion
//
// #region Prototype
// // BAD PRACTICE ALERT! First let's try to clone object with the single dumbest method ever
// var student1 = new BadPrototype.Student(
//     "Bob Jefferson",
//     new[] { "Calculus", "Physics" },
//     new BadPrototype.ContactInfo("11111111", "Jefferson st. 11"));
//
// var student2 = student1;
// student2.FullName = "Michael Jefferson"; // Seeya later, Bob!
//
// Console.WriteLine(student1);
// Console.WriteLine(student2);
//
// // BAD PRACTICE ALERT! Next let's try with ICloneable, which isn't recommended to use
// var student3 = (BadPrototype.Student)student1.Clone();
// student3.FullName = "Steve Jefferson";
// student3.ContactInfo.PhoneNumber = "33333333";
// Console.WriteLine(student3);
// Console.WriteLine(student1);
//
// // Now let's try the same using copy constructors
// var student4 = new GoodPrototypeCopyConstructors.Student(
//     "Colby Robbins",
//     new[] { "Linear Algebra", "Machine Learning" },
//     new GoodPrototypeCopyConstructors.ContactInfo("444444444", "Robbins st. 55"));
//
// Console.WriteLine(student4);
//
// var student5 = new GoodPrototypeCopyConstructors.Student(student4);
// student5.ContactInfo.Address = "Robbins st. 77";
// student5.Subjects = new[] { "Genetic Algorithms" };
//
// Console.WriteLine(student5);
//
// // There is another method with the explicit deep copy interface
// var student6 = new GoodPrototypeExplicitDeepCopyInterface.Student(
//     "Dean Cooper",
//     new[] { "Linear Algebra", "Machine Learning" },
//     new GoodPrototypeExplicitDeepCopyInterface.ContactInfo("66666666", "Cooper st. 54"));
//
// Console.WriteLine(student6);
//
// var student7 = student6.DeepCopy();
// student7.FullName = "James Butler";
// student7.ContactInfo.PhoneNumber = "77777777";
//
// Console.WriteLine(student7);
//
// // The same job can be done using serialization techniques:
// var student8 = new GoodPrototypeSerializer.Student(
//     "Holly Adams",
//     new[] { "Machine Learning" },
//     new GoodPrototypeSerializer.ContactInfo("8888888", "Adams st. 33"));
//
// Console.WriteLine(student8);
//
// var student9 = student8.DeepCopy();
// student9.ContactInfo.PhoneNumber = "99999999";
//
// Console.WriteLine(student9);
//
// #endregion
//
// #region Singleton
//
// // First let's compare whether or not all non singleton instances are the same:
// var nsb1 = new NonSingletonLoadBalancer();
// var nsb2 = new NonSingletonLoadBalancer();
// var nsb3 = new NonSingletonLoadBalancer();
// var nsb4 = new NonSingletonLoadBalancer();
// if (nsb1 == nsb2 && nsb2 == nsb3 && nsb3 == nsb4)
//     Console.WriteLine("Non singleton instances are the same\n");
// else
//     Console.WriteLine("Non singleton instances are NOT the same\n");
//
// // Then do the same for singleton instances:
// var b1 = SingletonLoadBalancer.GetLoadBalancer();
// var b2 = SingletonLoadBalancer.GetLoadBalancer();
// var b3 = SingletonLoadBalancer.GetLoadBalancer();
// var b4 = SingletonLoadBalancer.GetLoadBalancer();
// if (b1 == b2 && b2 == b3 && b3 == b4)
//     Console.WriteLine("Singleton instances are the same\n");
// else
//     Console.WriteLine("Singleton instances are NOT the same\n");
//
// // Let's imagine, having two load balancers working together for scalability
//
// // First send 10 requests to the non-singleton load balancers
// Console.WriteLine("Non singleton load balancers receive requests:");
// var nonSingletonBalancer1 = new NonSingletonLoadBalancer();
// var nonSingletonBalancer2 = new NonSingletonLoadBalancer();
// for (int i = 0; i < 10; i++)
// {
//     var nonSingletonServer1 = nonSingletonBalancer1.NextServer.Name;
//     Console.WriteLine($"Dispatch request to: {nonSingletonServer1}");
//
//     var nonSingletonServer2 = nonSingletonBalancer2.NextServer.Name;
//     Console.WriteLine($"Dispatch request to: {nonSingletonServer2}");
// }
//
// // Now send 10 requests to the singleton load balancers
// Console.WriteLine("\nSingleton load balancers receive requests:");
// var balancer3 = SingletonLoadBalancer.GetLoadBalancer();
// var balancer4 = SingletonLoadBalancer.GetLoadBalancer();
// for (int i = 0; i < 10; i++)
// {
//     var server3 = balancer3.NextServer.Name;
//     Console.WriteLine($"Dispatch request to: {server3}");
//
//     var server4 = balancer4.NextServer.Name;
//     Console.WriteLine($"Dispatch request to: {server4}");
// }
// #endregion
//
// #endregion
//
// #region Structural
//
// #region Adapter
// // First with object adapter pattern
// IEmployeeService employeeService1 = new ObjectEmployeeAdapter(new RecordServer());
// var employee1 = employeeService1.GetEmployee(2);
// Console.WriteLine(employee1);
//
// //Now with class adapter pattern
// IEmployeeService employeeService2 = new ClassEmployeeAdapter();
// var employee2 = employeeService2.GetEmployee(3);
// Console.WriteLine(employee2);
//
// #endregion
//
// #region Facade
// QRCodeGenerator qrGenerator = new QRCodeGenerator();
// QRCodeData qrCodeData = qrGenerator.CreateQrCode("Casino Engine Team", QRCodeGenerator.ECCLevel.Q);
// QRCode qrCode = new QRCode(qrCodeData);
// System.Drawing.Bitmap qrCodeImage = qrCode.GetGraphic(702);
//
// ConsoleDraw.ConsoleWriteImage(qrCodeImage);
// #endregion
//
// #region Proxy
// WebParser parser = new WebParser("https://github.com/");
// Console.WriteLine(parser.GetSectionsCount());
//
// LazyWebParserProxy lazyWebParser = new LazyWebParserProxy("https://github.com/");
// Console.WriteLine(lazyWebParser.GetSectionsCount());
// Console.WriteLine(lazyWebParser.GetPagesCount());
// #endregion
//
// #region Decorator
//
// // First let's create a basic types of chocolate
//
// var basicBrown = new BrownChocolate();
// Console.WriteLine(basicBrown.GetInfo());
//
// Console.WriteLine();
//
// var basicBlack = new BlackChocolate();
// Console.WriteLine(basicBlack.GetInfo());
//
// Console.WriteLine();
//
// // Now let's create decorated chocolate objects
//
// // Black with nut:
//
// var blackWithNut = new NutAddon(basicBlack);
// Console.WriteLine(blackWithNut.GetInfo());
//
// Console.WriteLine();
//
// var brownWithMilk = new MilkAddon(basicBrown);
// Console.WriteLine(brownWithMilk.GetInfo());
//
// Console.WriteLine();
//
// var brownWithCherry = new CherryAddon(basicBrown);
// Console.WriteLine(brownWithCherry.GetInfo());
//
// #endregion
//
// #region Bridge
// var remote = new NormalRemoteControl(new Tv());
// remote.IncreaseVolume();
//
// var advancedRemote = new AdvancedRemoteControl(new MusicPlayer());
// advancedRemote.Mute();
// #endregion
//
// #region Composite
// // First let's create a singular gift:
// var bike = new SingularGift("Mountain bike", 3500);
// bike.CalculateTotalCost();
//
// // Now let's construct a composite gift:
// var fedexBox = new CompositeGift("Fedex box", 2);
// var vendorBox = new CompositeGift("Apple box", 10);
// var laptop = new SingularGift("Macbook Pro", 4000);
// var chargerBox = new CompositeGift("Charger box", 5);
// var charger = new SingularGift("Charger", 70);
//
// chargerBox.AddGift(charger);
// vendorBox.AddGift(laptop);
// vendorBox.AddGift(chargerBox);
// fedexBox.AddGift(vendorBox);
//
// var totalCost = fedexBox.CalculateTotalCost();
// Console.WriteLine($"Total cost: {totalCost}");
//
// #endregion
//
// #region Flyweight
// // One real-life example of flyweight is string interning in C#
// var s1 = "Giorgi Kobaidze";
// var s2 = new StringBuilder().Append("Giorgi").Append(" Kobaidze").ToString();
// var s3 = string.Intern(s2); // Instances of s3 and s1 will be the same, because s1 exists as a literal
//
// Console.WriteLine($"s1 == s2: {(object)s1 == (object)s2}");
// Console.WriteLine($"s2 == s3: {(object)s2 == (object)s3}");
// Console.WriteLine($"s1 == s3: {(object)s1 == (object)s3}");
//
//
// // Now a small conceptual example:
// var factory = new FlyweightFactory(
//     new Soldier("Human", "Swordsman"),
//     new Soldier("Elf", "Archer"),
//     new Soldier("Orc", "Brute"),
//     new Soldier("Human", "Cavalry"));
//
// factory.ListAllFlyweights();
//
// factory.AddNewObject(new Soldier("Elf", "Swordsman", 12, 15));
// factory.AddNewObject(new Soldier("Human", "Swordsman", 10, 12));
//
// factory.ListAllFlyweights();
// #endregion
//
// #endregion

#region Behavioral

#region ChainOfResponsibility

IApprover casinoAutomation = new CasinoAutomation();
IApprover casinoOperator = new CasinoOperator();
IApprover casinoManager = new CasinoManager();

casinoAutomation.NextApprover = casinoOperator;
casinoOperator.NextApprover = casinoManager;

var transactionRequest = new TransactionRequest { Amount = 70000 };
casinoAutomation.ProcessRequest(transactionRequest);

#endregion

#endregion
