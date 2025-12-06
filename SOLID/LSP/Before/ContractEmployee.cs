using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.LSP.Before
{
    public class ContractEmployee : Employee
    {
        public override decimal CalculateBonus()
        {
            throw new NotImplementedException(); // Contract employees do not receive a bonus
        }

        public override decimal CalculateSalary()
        {
            return 4000m;
        }
    }
}
