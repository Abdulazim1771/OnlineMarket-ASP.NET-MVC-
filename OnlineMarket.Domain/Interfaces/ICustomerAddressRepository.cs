using OnlineMarket.Domain.Entities;

namespace OnlineMarket.Domain.Interfaces;

public interface ICustomerAddressRepository : IRepositoryBase<CustomerAddress>
{
    List<CustomerAddress> GetAll();
}
