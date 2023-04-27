using WebApplication1.Implementations;
using WebApplication1.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddSingleton<IAddSingleton, AddSingleton>();
builder.Services.AddTransient<IAddTransient, AddTransient>();
builder.Services.AddScoped<IAddScoped, AddScoped>();
builder.Services.AddSingleton<IUseSingleton, UseSingleton>();
builder.Services.AddTransient<IUseTransient, UseTransient>();
builder.Services.AddScoped<IUseScoped, UseScoped>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
