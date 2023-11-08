using MyErp.Business.Interfaces;
using MyErp.DAL;

namespace MyErp.Business.Repositories;

public class CustomerRepository : ICustomerRepository
{
    public List<Customer> GetAll()
    {
        return ErpDb.Customers;
    }

    public void Create(Customer obj)
    {
        ErpDb.Customers.Add(obj);
    }
}
