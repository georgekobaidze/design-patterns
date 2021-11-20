using DesignPatterns.Solid.OpenClosed.Enums;

namespace DesignPatterns.Solid.OpenClosed;

public class Vehicle
{
    public Brand Brand { get; set; }
    public VehicleType VehicleType { get; set; }
    public Color Color { get; set; }
    public decimal Engine { get; set; }

    public Vehicle(Brand brand, VehicleType vehicleType, Color color, decimal engine)
    {
        Brand = brand;
        VehicleType = vehicleType;
        Color = color;
        Engine = engine;
    }
}
