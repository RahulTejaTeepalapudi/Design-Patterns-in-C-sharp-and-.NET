using SOLID.LSP.After.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.LSP.After.Implementations
{
    public class TemporaryEmployee : Employee
    {
        public override decimal CalculateBonus()
        {
            return CalculateSalary() * 0.05m;
        }

        public override decimal CalculateSalary()
        {
            return 3000m;
        }
    }
}
