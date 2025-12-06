using SOLID.LSP.After.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.LSP.After.Implementations
{
    public class PermanentEmployee : Employee
    {
        public override decimal CalculateBonus()
        {
            return CalculateSalary() * 0.1m;
        }

        public override decimal CalculateSalary()
        {
            return 5000m;
        }
    }
}
