using System.Collections.Generic;
using DesignPatterns.Solid.OpenClosed.Filters.Good.Interfaces;

namespace DesignPatterns.Solid.OpenClosed.Filters.Good;

public class VehicleFilter : IFilter<Vehicle>
{
    public IEnumerable<Vehicle> Filter(IEnumerable<Vehicle> items, ISpecification<Vehicle> spec)
    {
        foreach (var item in items)
            if (spec.IsSatisfied(item))
                yield return item;
    }
}
