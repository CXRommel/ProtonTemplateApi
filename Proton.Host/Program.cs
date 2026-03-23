using Microsoft.AspNetCore.Mvc;
using Proton.Services;
using Proton.Repositories.Extensions;
using Proton.Services.Extensions;

var builder = WebApplication.CreateBuilder(args);

string BuildConnectionString(string connectionString) 
    => $"{connectionString};User Id={builder.Configuration["DbUser"]};Password={builder.Configuration["DbPassword"]}";

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddProtonRepositories(connectionString: BuildConnectionString(builder.Configuration.GetConnectionString("Schools")));
builder.Services.AddProtonServices();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapGet("/users/{id:long}", (
    [FromRoute] long id,
    [FromServices] IUsersService userService) => userService.GetAsync(id))
.WithName("GetUserById")
.WithOpenApi();


app.Run();


