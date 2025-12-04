using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OCP.After.Interfaces
{
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> specification);
    }
}
