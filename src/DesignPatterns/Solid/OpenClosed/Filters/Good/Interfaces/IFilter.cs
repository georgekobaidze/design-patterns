using System.Collections.Generic;

namespace DesignPatterns.Solid.OpenClosed.Filters.Good.Interfaces;

public interface IFilter<T>
{
    IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
}
