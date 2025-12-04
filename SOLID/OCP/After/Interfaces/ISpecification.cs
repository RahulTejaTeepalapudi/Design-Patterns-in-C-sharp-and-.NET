using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OCP.After.Interfaces
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T item);
    }
}
