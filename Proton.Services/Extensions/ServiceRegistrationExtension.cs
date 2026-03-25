using Microsoft.Extensions.DependencyInjection;

namespace Proton.Services.Extensions;

public static class ServiceRegistrationExtension
{
    public static IServiceCollection AddProtonServices(this IServiceCollection services)
    {
        services.AddScoped<IUsersService, UsersService>();

        return services;
    }
}