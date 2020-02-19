using System;

namespace DependencyInversionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer("Alin", new SQLCustomerRepository());
            c1.Save();

            Customer c2 = new Customer("Alin", new OracleCustomerRepository());
            c2.Save();
        }
    }
}
