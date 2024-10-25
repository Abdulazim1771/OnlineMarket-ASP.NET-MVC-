using OnlineMarket.Domain.Entities;

namespace OnlineMarket.Domain.Interfaces;

public interface ICategoryRepository : IRepositoryBase<Category>
{
    List<Category> GetAll(string? search);
}
