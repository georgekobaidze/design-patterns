using DesignPatterns.Solid.OpenClosed.Enums;
using DesignPatterns.Solid.OpenClosed.Filters.Good.Interfaces;

namespace DesignPatterns.Solid.OpenClosed.Filters.Good.Specifications;

public class ColorSpecification : ISpecification<Vehicle>
{
    private Color _color;

    public ColorSpecification(Color color) => _color = color;

    public bool IsSatisfied(Vehicle vehicle) => vehicle.Color == _color;
}
