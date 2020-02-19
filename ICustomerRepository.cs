namespace DependencyInversionPrinciple
{
    public interface ICustomerRepository
    {
        void Save(Customer customer);
    }
}