using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace OnlineMarket.Application.Extensions;

public static class DependencyInjection
{
    public static IServiceCollection RegisterApplication(
        this IServiceCollection services, IConfiguration configuration)
    {


        return services;
    }
}
