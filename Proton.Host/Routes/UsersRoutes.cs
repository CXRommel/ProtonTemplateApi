using Microsoft.AspNetCore.Mvc;
using Proton.Host.Endpoints;
using Proton.Models;

namespace Proton.Host.Routes;

public static class UsersRoutes
{
    public static WebApplication MapUsers(this WebApplication app, string prefix = "users")
    {
        var group = app.MapGroup("/" + prefix);
        
        group.MapGet("/{id:long}", (
                [FromRoute] long id,
                [FromServices] IUsersEndpoint endpoint) => endpoint.GetAsync(id))
            .WithName("GetUserById")
            .WithOpenApi();
        
        group.MapPost("", (
                [FromBody] UserModel model,
                [FromServices] IUsersEndpoint endpoint) => endpoint.CreateAsync(model))
            .WithName("CreateUser")
            .WithOpenApi();
        
        group.MapPut("", (
                [FromBody] UserModel model,
                [FromServices] IUsersEndpoint endpoint) => endpoint.UpdateAsync(model.Id, model))
            .WithName("UpdateUser")
            .WithOpenApi();
        
        group.MapDelete("/{id:long}", (
                [FromRoute] long id,
                [FromServices] IUsersEndpoint endpoint) => endpoint.DeleteAsync(id))
            .WithName("DeleteUser")
            .WithOpenApi();
        
        return app;
    }
}