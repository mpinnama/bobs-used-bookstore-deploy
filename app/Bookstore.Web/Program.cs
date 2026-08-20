using Microsoft.AspNetCore.Builder;
using Bookstore.Web.Startup;

var builder = WebApplication.CreateBuilder(args);

builder
    .ConfigureConfiguration()
    .ConfigureAuthentication()
    .ConfigureServices()
    .ConfigureDependencyInjection();

var app = builder.Build();

await app.ConfigureMiddlewareAsync();

app.Run();
