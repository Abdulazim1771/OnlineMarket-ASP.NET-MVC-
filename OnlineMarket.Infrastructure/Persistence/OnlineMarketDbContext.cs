﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineMarket.Domain.Entities;
using System.Reflection;

namespace OnlineMarket.Infrastructure.Persistence;

public class OnlineMarketDbContext : IdentityDbContext<Customer, CustomerRole, string>
{
    public virtual DbSet<Product> Products { get; set; }
    public virtual DbSet<Category> Categories { get; set; }
    public virtual DbSet<CustomerAddress> CustomerAddresses { get; set; }
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

        //#region Identity

        //modelBuilder.Entity<IdentityUser<Guid>>(b =>
        //{
        //    b.ToTable("Customer");
        //});

        //modelBuilder.Entity<IdentityUserClaim<Guid>>(b =>
        //{
        //    b.ToTable("UserClaim");
        //});

        //modelBuilder.Entity<IdentityUserLogin<Guid>>(b =>
        //{
        //    b.ToTable("UserLogin");
        //});

        //modelBuilder.Entity<IdentityUserToken<Guid>>(b =>
        //{
        //    b.ToTable("UserToken");
        //});

        //modelBuilder.Entity<IdentityRole<Guid>>(b =>
        //{
        //    b.ToTable("CustomerRole");
        //});

        //modelBuilder.Entity<IdentityRoleClaim<Guid>>(b =>
        //{
        //    b.ToTable("RoleClaim");
        //});

        //modelBuilder.Entity<IdentityUserRole<Guid>>(b =>
        //{
        //    b.ToTable("UserRole");
        //});

        //#endregion
    }
}
