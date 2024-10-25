using Microsoft.EntityFrameworkCore;
using OnlineMarket.Domain.Entities;
using OnlineMarket.Domain.Interfaces;

namespace OnlineMarket.Infrastructure.Persistence.Repositories;

internal class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
{
    public CategoryRepository(OnlineMarketDbContext context)
        : base(context)
    {      
    }

    public List<Category> GetAll(string? search)
    {
        var query = _context.Categories
            .AsNoTracking();

        if(!string.IsNullOrWhiteSpace(search))
        {
            query = query.Where(x => x.Name.Contains(search));
        }

        var entities = query.ToList();

        return entities;
    }

    public override List<Category> GetAll()
    {
        var categories = _context.Categories
            .AsNoTracking()
            .ToList();

        return categories;
    }
}
