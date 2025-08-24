using Application.Stores;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<StoreCommandHandler>();
        services.AddScoped<StoreQueryHandler>();
        return services;
    }
}
