using System;

namespace DependencyInversionPrinciple
{
    public class OracleCustomerRepository : ICustomerRepository
    {
        public void Save(Customer customer)
        {
            Console.WriteLine($"Saving customer {customer.Name} in Oracle Server database!");
        }
    }
}