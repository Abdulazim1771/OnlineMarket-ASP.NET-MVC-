using OnlineMarket.Application.Extensions;
using OnlineMarket.Infrastructure.Extensions;
using Syncfusion.Licensing;

namespace OnlineMarket_ASP.NET_.Extensions;

public static class DependencyInjection
{
    public static IServiceCollection ConfigureServices(
        this IServiceCollection services, IConfiguration configuration)
    {
        services.RegisterInfrastructure(configuration);
        services.RegisterApplication(configuration);

        AddProviders(configuration);

        return services;
    }

    private static void AddProviders(IConfiguration configuration)
    {
        var syncfusionKey = configuration.GetValue<string>("SyncfusionKey")
            ?? throw new InvalidOperationException("Syncfusion key is not found.");

        SyncfusionLicenseProvider.RegisterLicense(syncfusionKey);
    }
}
