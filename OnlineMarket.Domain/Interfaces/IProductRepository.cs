using OnlineMarket.Domain.Entities;

namespace OnlineMarket.Domain.Interfaces;

public interface IProductRepository : IRepositoryBase<Product>
{
    List<Product> GetAll(int? categoryId, string? search);
}
