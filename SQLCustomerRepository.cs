using System;

namespace DependencyInversionPrinciple
{
    public class SQLCustomerRepository : ICustomerRepository
    {
        public void Save(Customer c)
        {
            Console.WriteLine($"Saving customer {c.Name} in SQL Server database!");
        }
    }
}