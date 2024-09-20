using OnlineMarket.Domain.Entities;

namespace OnlineMarket.Domain.Interfaces;

public interface IProductRepository : IRepositoryBase<Product>
{
    List<Product> GetAll(string? search);
}
