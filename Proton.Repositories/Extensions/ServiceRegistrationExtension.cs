using Microsoft.Extensions.DependencyInjection;

namespace Proton.Repositories.Extensions;

public static class ServiceRegistrationExtension
{
    public static void AddProtonRepositories(this IServiceCollection services)
    {
        services.AddScoped<IUsersRepository, UsersRepository>();
    } 
}