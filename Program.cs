using System;

namespace DependencyInversionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer("Alin", new CustomerRepository());
            c.Save();
        }
    }
}
