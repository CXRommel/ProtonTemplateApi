using Microsoft.Extensions.DependencyInjection;

namespace Proton.Services.Extensions;

public static class ServiceRegistrationExtension
{
    public static void AddProtonServices(this IServiceCollection services)
    {
        services.AddScoped<IUsersService, UsersService>();
    }
}