using Proton.Host.Endpoints;

namespace Proton.Host.Extensions;

public static class ServiceRegistrationExtension
{
    public static IServiceCollection AddProtonEndpointsService(this IServiceCollection services)
    {
        services.AddScoped<IUsersEndpoint, UsersEndpoint>();

        return services;
    }
}