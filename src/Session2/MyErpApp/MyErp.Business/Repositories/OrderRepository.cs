using MyErp.Business.Interfaces;
using MyErp.DAL;

namespace MyErp.Business.Repositories;

public class OrderRepository : IOrderRepository
{
    public List<Order> GetAll()
    {
        return ErpDb.Orders;
    }

    public void Create(Order obj)
    {
        ErpDb.Orders.Add(obj);
    }
}
