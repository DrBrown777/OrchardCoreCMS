var builder = WebApplication.CreateBuilder(args);

IServiceCollection services = builder.Services;

services.AddOrchardCms();

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.UseOrchardCore();

app.Run();
