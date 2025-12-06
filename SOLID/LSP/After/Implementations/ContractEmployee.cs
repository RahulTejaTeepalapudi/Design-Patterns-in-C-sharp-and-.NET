using SOLID.LSP.After.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.LSP.After.Implementations
{
    public class ContractEmployee : IEmployee
    {
        public decimal CalculateSalary()
        {
            return 4000m;
        }
    }
}
