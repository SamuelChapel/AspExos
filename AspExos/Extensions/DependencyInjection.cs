using AspExos.Persistence.Context;
using AspExos.Persistence.Repositories;
using AspExos.Services;

namespace AspExos.Extensions;

public static class DependencyInjection
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<IRandomService, RandomService>();

        services.AddDbContext<ApplicationDbContext>();

        services.AddScoped<MessageRepository>();

        return services;
    }
}
