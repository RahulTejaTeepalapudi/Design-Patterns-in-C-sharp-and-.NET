using SOLID.LSP.After.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.LSP.After.Abstracts
{
    public abstract class Employee : IEmployee, IEmployeeBonus
    {
        public abstract decimal CalculateSalary();
        public abstract decimal CalculateBonus();
    }
}
