using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.LSP.Before
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
