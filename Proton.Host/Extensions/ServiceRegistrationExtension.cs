using Proton.Host.Endpoints;
using Proton.Host.Services;

namespace Proton.Host.Extensions;

public static class ServiceRegistrationExtension
{
    public static IServiceCollection AddProtonEndpointsService(this IServiceCollection services)
    {
        services.AddScoped<AuthorizationContextService>();
        
        services.AddScoped<IUsersEndpoint, UsersEndpoint>();

        return services;
    }
}