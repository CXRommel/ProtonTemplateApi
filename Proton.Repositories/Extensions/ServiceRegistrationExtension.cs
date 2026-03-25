using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Proton.Common.Mapper;
using Proton.Common.Validator;
using Proton.Models;
using Proton.Repositories.DbContexts;
using Proton.Repositories.Entities;
using Proton.Repositories.Mappers;

namespace Proton.Repositories.Extensions;

public static class ServiceRegistrationExtension
{
    public static IServiceCollection AddProtonRepositories(this IServiceCollection services, string? connectionString)
    {
        services
            .Val()
            .IsNotNull();
        
        connectionString 
            .Val() 
            .IsNotNull() 
            .IsNotEmptyString();
        
        services.AddScoped<IUsersRepository, UsersRepository>();

        services.AddDbContext<SchoolDbContext>(options =>
            options.UseSqlServer(connectionString));


        services.AddSingleton<IMapper<UserModel, UserEntity>, UserMapper>();

        return services;
    } 
}

