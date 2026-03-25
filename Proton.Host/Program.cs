using Proton.Host.Extensions;
using Proton.Repositories.Extensions;
using Proton.Services.Extensions;

var builder = WebApplication.CreateBuilder(args);

string BuildConnectionString(string connectionString) 
    => $"{connectionString};User Id={builder.Configuration["DbUser"]};Password={builder.Configuration["DbPassword"]}";

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services
    .AddProtonRepositories(
        connectionString: BuildConnectionString(builder.Configuration.GetConnectionString("Schools")))
    .AddProtonServices()
    .AddProtonEndpointsService();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app
    .MapProtonRoutes()
    .Run();


