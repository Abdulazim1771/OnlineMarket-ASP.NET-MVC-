using Microsoft.EntityFrameworkCore;
using OnlineMarket.Domain.Entities;
using System.Reflection;

namespace OnlineMarket.Infrastructure.Persistence;

public class OnlineMarketDbContext : DbContext
{
    public virtual DbSet<Product> Products { get; set; }
    public virtual DbSet<Category> Categories { get; set; }
    public virtual DbSet<Inventory> Inventories { get; set; }
    public virtual DbSet<ImageFile> ImageFiles { get; set; }
    public virtual DbSet<Review> Reviews { get; set; }
    public virtual DbSet<Order> Orders { get; set; }
    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public OnlineMarketDbContext(DbContextOptions<OnlineMarketDbContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        base.OnModelCreating(modelBuilder);
    }
}
