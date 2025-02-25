var builder = WebApplication.CreateBuilder(args);

// Add services to the container. - Dependency Injection

// Add MVC - Model-View-Controller - services to the services container
// builder.Services.AddControllers();

// add transient service 
// builder.Services.AddTransient<ICustomerService, CustomerService>();
// it creates a new instance of the service for each request

// add scoped service
// builder.Services.AddScoped<ICustomerService, CustomerService>();
// it creates a new instance of the service for each scope

// add singleton service
// builder.Services.AddSingleton<ICustomerService, CustomerService>();
// it creates a single instance of the service for the lifetime of the application

builder.Services
    .AddCatalogModule(builder.Configuration)
    .AddBasketModule(builder.Configuration)
    .AddOrderingModule(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline. - middleware

app
    .UseCatalogModule()
    .UseBasketModule()
    .UseOrderingModule();

app.Run();
