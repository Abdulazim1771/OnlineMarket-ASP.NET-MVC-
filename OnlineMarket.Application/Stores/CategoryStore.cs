using OnlineMarket.Application.Stores.Interfaces;
using OnlineMarket.Domain.Interfaces;

namespace OnlineMarket.Application.Stores;

public class CategoryStore : ICategoryStore
{
    private readonly ICommonRepository _repository;

    public CategoryStore(ICommonRepository repository)
    {
        _repository = repository;
    }
}
