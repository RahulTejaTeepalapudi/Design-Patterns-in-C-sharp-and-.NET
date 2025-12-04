using SOLID.OCP.After.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OCP.After.Implementations
{
    public class AndSpecification<T>(ISpecification<T> first, ISpecification<T> second) : ISpecification<T>
    {
        private readonly ISpecification<T> first = first;
        private readonly ISpecification<T> second = second;

        public bool IsSatisfied(T item)
        {
            return first.IsSatisfied(item) && second.IsSatisfied(item);
        }
    }
}
