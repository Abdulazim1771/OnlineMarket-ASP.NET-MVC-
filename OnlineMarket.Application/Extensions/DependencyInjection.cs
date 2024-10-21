using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnlineMarket.Application.Stores;
using OnlineMarket.Application.Stores.Interfaces;

namespace OnlineMarket.Application.Extensions;

public static class DependencyInjection
{
    public static IServiceCollection RegisterApplication(
        this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<ICategoryStore, CategoryStore>();

        return services;
    }
}
