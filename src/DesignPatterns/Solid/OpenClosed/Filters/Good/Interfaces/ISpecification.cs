namespace DesignPatterns.Solid.OpenClosed.Filters.Good.Interfaces;

public interface ISpecification<T>
{
    bool IsSatisfied(T t);
}
