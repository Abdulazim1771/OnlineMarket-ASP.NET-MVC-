using Microsoft.EntityFrameworkCore;
using OnlineMarket.Domain.Entities;
using OnlineMarket.Domain.Interfaces;

namespace OnlineMarket.Infrastructure.Persistence.Repositories;

internal class ProductRepository : RepositoryBase<Product>, IProductRepository
{
    private List<Product> _products;

    public ProductRepository(OnlineMarketDbContext context)
        : base(context)
    {
        _products = [];
    }

    public override List<Product> GetAll()
    {
        var products = _context.Products
            .AsNoTracking()
            .ToList();

        return products;
    }

    public List<Product> GetAll(int? categoryId, string? search)
    {
        var query = _context.Products
            .AsNoTracking();

        if(!string.IsNullOrEmpty(search))
        {
            query = query.Where(x => x.Name.Contains(search) ||
            x.Description != null && x.Description.Contains(search));
        }

        if(categoryId.HasValue)
        {
            query = query.Where(p => p.CategoryId == categoryId);
        }

        var products = query.ToList();

        return products;
    }
}
