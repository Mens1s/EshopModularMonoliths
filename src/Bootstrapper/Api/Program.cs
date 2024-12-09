var builder = WebApplication.CreateBuilder(args);

// Add services to the container. - Dependency Injection

var app = builder.Build();

// Configure the HTTP request pipeline.

app.Run();
