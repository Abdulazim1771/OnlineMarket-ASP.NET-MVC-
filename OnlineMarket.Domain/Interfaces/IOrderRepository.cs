using OnlineMarket.Domain.Entities;

namespace OnlineMarket.Domain.Interfaces;

public interface IOrderRepository : IRepositoryBase<Order>
{
    List<Order> GetAll();
}
