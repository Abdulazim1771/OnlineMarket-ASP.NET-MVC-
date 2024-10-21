using OnlineMarket.Domain.Entities;

namespace OnlineMarket.Domain.Interfaces;

public interface IOrderDetailRepository : IRepositoryBase<OrderDetail>
{
    List<OrderDetail> GetAll();
}
