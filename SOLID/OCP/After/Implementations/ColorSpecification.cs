using SOLID.OCP.After.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OCP.After.Implementations
{
    public class ColorSpecification(Color color) : ISpecification<Product>
    {
        private readonly Color color = color;

        public bool IsSatisfied(Product item)
        {
            return item.Color == color;
        }
    }
}
