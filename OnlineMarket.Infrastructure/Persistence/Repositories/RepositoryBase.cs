using Microsoft.EntityFrameworkCore;
using OnlineMarket.Domain.Common;
using OnlineMarket.Domain.Exceptions;
using OnlineMarket.Domain.Interfaces;

namespace OnlineMarket.Infrastructure.Persistence.Repositories;

internal abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : EntityBase
{
    protected readonly OnlineMarketDbContext _context;

    protected RepositoryBase(OnlineMarketDbContext context)
    {
        _context = context;
    }

    public abstract List<TEntity> GetAll(string customerId);

    public virtual TEntity GetById(int id)
    {
        var entity = GetOrThrow(id);

        return entity;
    }

    public TEntity Create(TEntity entity)
    {
        ArgumentNullException.ThrowIfNull(entity);

        _context.Set<TEntity>().Add(entity);

        return entity;
    }

    public void Update(TEntity entity)
    {
        ArgumentNullException.ThrowIfNull(entity);

        _context.Set<TEntity>().Update(entity);
    }

    public void Delete(int id)
    {
        var entity = GetOrThrow(id);

        _context.Set<TEntity>().Remove(entity);
    }

    private TEntity GetOrThrow(int id)
    {
        var entity = _context.Set<TEntity>()
            .AsNoTracking()
            .FirstOrDefault(x => x.Id == id);

        if(entity is null)
        {
            throw new EntityNotFoundException($"{typeof(TEntity)} with id:{id} is not found");
        }

        return entity;
    }

}
