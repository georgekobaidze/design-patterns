using System.Collections.Generic;
using DesignPatterns.Solid.OpenClosed.Enums;

namespace DesignPatterns.Solid.OpenClosed.Filters.Bad;

public class VehicleFilter
{
    public IEnumerable<Vehicle> FilterByBrand(IEnumerable<Vehicle> vehicles, Brand brand)
    {
        foreach (var vehicle in vehicles)
            if (vehicle.Brand == brand)
                yield return vehicle;
    }

    public IEnumerable<Vehicle> FilterByColor(IEnumerable<Vehicle> vehicles, Color color)
    {
        foreach (var vehicle in vehicles)
            if (vehicle.Color == color)
                yield return vehicle;
    }

    public IEnumerable<Vehicle> FilterByBrandAndType(List<Vehicle> vehicles, Brand brand, VehicleType vehicleType)
    {
        foreach (var vehicle in vehicles)
            if (vehicle.Brand == brand && vehicle.VehicleType == vehicleType)
                yield return vehicle;
    }

    // Do you see where is it going?
}
