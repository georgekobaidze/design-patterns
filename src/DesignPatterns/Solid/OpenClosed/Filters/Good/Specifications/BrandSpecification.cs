using DesignPatterns.Solid.OpenClosed.Enums;
using DesignPatterns.Solid.OpenClosed.Filters.Good.Interfaces;

namespace DesignPatterns.Solid.OpenClosed.Filters.Good.Specifications;

public class BrandSpecification : ISpecification<Vehicle>
{
    private Brand _brand;

    public BrandSpecification(Brand brand) => _brand = brand;

    public bool IsSatisfied(Vehicle vehicle) => vehicle.Brand == _brand;
}
