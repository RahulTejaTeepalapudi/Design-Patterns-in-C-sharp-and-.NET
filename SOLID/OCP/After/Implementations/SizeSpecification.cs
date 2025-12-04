using SOLID.OCP.After.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OCP.After.Implementations
{
    public class SizeSpecification(Size size) : ISpecification<Product>
    {
        private readonly Size size = size;

        public bool IsSatisfied(Product item)
        {
            return item.Size == size;
        }
    }
}
