using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnlineMarket.Domain.Entities;
using OnlineMarket.Domain.Interfaces;
using OnlineMarket.Infrastructure.Persistence;
using OnlineMarket.Infrastructure.Persistence.Repositories;

namespace OnlineMarket.Infrastructure.Extensions;

public static class DependencyInjection
{
    public static IServiceCollection RegisterInfrastructure(
        this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<ICommonRepository, CommonRepository>();
        services.AddScoped<ICustomerAddressRepository, CustomerAddressRepository>();
        services.AddScoped<ICustomerRepository, CustomerRepository>();
        services.AddScoped<IOrderRepository, OrderRepository>();
        services.AddScoped<IOrderDetailRepository, OrderDetailRepository>();
        services.AddScoped<IImageFileRepository, ImageFileRepository>();
        services.AddScoped<IInventoryRepository, InventoryRepository>();
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<IReviewRepository, ReviewRepository>();

        services.AddDbContext<OnlineMarketDbContext>(options =>
        options.UseSqlServer(configuration.GetConnectionString("OnlineMarketDbConnection")));

        services.AddIdentity<Customer, CustomerRole>(options =>
        {
            
        })
        .AddEntityFrameworkStores<OnlineMarketDbContext>()
        .AddDefaultTokenProviders();

        return services;
    }
}

