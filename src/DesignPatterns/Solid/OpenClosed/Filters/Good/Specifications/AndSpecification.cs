﻿using DesignPatterns.Solid.OpenClosed.Filters.Good.Interfaces;

namespace DesignPatterns.Solid.OpenClosed.Filters.Good.Specifications;

public class AndSpecification<T> : ISpecification<T>
{
    private readonly ISpecification<T> _first;
    private readonly ISpecification<T> _second;

    public AndSpecification(ISpecification<T> first, ISpecification<T> second)
    {
        _first = first;
        _second = second;
    }

    public bool IsSatisfied(T t) => _first.IsSatisfied(t) && _second.IsSatisfied(t);
}
