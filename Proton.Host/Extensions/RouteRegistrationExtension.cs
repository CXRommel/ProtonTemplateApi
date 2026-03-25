using Microsoft.AspNetCore.Mvc;
using Proton.Host.Routes;
using Proton.Services;

namespace Proton.Host.Extensions;

public static class RouteRegistrationExtension
{

    public static WebApplication MapProtonRoutes(this WebApplication app)
    {
        app
            .MapUsers(prefix: "users");
        
        return app;
    }
}