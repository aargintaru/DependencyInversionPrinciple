using System;

namespace DependencyInversionPrinciple
{
    public class Customer
    {
        private CustomerRepository repository;
        public String Name { get; set; } 
        public Customer(String name, CustomerRepository cr)
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