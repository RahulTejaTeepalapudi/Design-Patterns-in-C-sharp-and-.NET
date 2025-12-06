using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class LSP
    {
        public static void Run()
        {
            Console.WriteLine("Liskov Substitution Principle (LSP) Example");
            // Before applying LSP

            var employeesBefore = new List<SOLID.LSP.Before.Employee>
            {
                new SOLID.LSP.Before.PermanentEmployee(),
                new SOLID.LSP.Before.TemporaryEmployee(),
                new SOLID.LSP.Before.ContractEmployee()
            };
            foreach (var emp in employeesBefore)
            {
                Console.WriteLine($"Salary: {emp.CalculateSalary()}");
                try
                {
                    Console.WriteLine($"Bonus: {emp.CalculateBonus()}");
                }
                catch (NotImplementedException)
                {
                    Console.WriteLine("Bonus calculation not implemented for this employee type.");
                }
            }

            // After applying LSP
            var employeesAfter = new List<SOLID.LSP.After.Abstracts.Employee>
            {
                new SOLID.LSP.After.Implementations.PermanentEmployee(),
                new SOLID.LSP.After.Implementations.TemporaryEmployee()
                // ContractEmployee is excluded as it does not fit the Employee abstraction
            };
            foreach (var emp in employeesAfter)
            {
                Console.WriteLine($"Salary: {emp.CalculateSalary()}");
                Console.WriteLine($"Bonus: {emp.CalculateBonus()}");
            }

            // After applying LSP
            var employeesBonus = new List<SOLID.LSP.After.Interfaces.IEmployeeBonus>
            {
                new SOLID.LSP.After.Implementations.PermanentEmployee(),
                new SOLID.LSP.After.Implementations.TemporaryEmployee(),
                // ContractEmployee is excluded as it does not fit the IEmployeeBonus contract
            };
            foreach (var emp in employeesBonus)
            {
                Console.WriteLine($"Bonus: {emp.CalculateBonus()}");
            }

            // After applying LSP
            var employeesSalary = new List<SOLID.LSP.After.Interfaces.IEmployee>
            {
                new SOLID.LSP.After.Implementations.PermanentEmployee(),
                new SOLID.LSP.After.Implementations.TemporaryEmployee(),
                new SOLID.LSP.After.Implementations.ContractEmployee(),
            };
            foreach (var emp in employeesSalary)
            {
                Console.WriteLine($"Bonus: {emp.CalculateSalary()}");
            }
        }
    }
}
