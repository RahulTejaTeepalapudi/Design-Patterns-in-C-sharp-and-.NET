using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.LSP.Before
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
