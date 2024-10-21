using OnlineMarket.Domain.Entities;

namespace OnlineMarket.Domain.Interfaces;

public interface ICustomerRepository 
{
    List<Customer> GetAll();
    Customer GetById(string id);
}
