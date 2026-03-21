using Microsoft.AspNetCore.Mvc;
using Proton.Services;
using Proton.Repositories.Extensions;
using Proton.Services.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddProtonRepositories();
builder.Services.AddProtonServices();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapGet("/users/{id:int}", (
    [FromRoute] int id,
    [FromServices] IUsersService userService) => userService.GetAsync(id))
.WithName("GetUserById")
.WithOpenApi();


app.Run();