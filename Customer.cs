using System;

namespace DependencyInversionPrinciple
{
    public class Customer
    {
        private ICustomerRepository repository;
        public String Name { get; set; } 
        public Customer(String name, ICustomerRepository cr)
        {
            this.repository = cr;
            this.Name = name;
        }

        public void Save()
        {
            repository.Save(this);
        }
    }
}