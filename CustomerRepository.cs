using System;

namespace DependencyInversionPrinciple
{
    public class CustomerRepository
    {
        public void Save(Customer c)
        {
            Console.WriteLine($"Saving customer {c.Name} in SQL Server database!");
        }
    }
}