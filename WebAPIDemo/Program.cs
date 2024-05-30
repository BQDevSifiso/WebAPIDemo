using Microsoft.EntityFrameworkCore;
using WebAPIDemo.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ShirtStoreManagement"));
});

// Add services to the container.
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection(); 

app.MapControllers();

//app.MapGet("/shirts", () =>
//{
//    return "Get all shirts";
//});

//app.MapGet("/shirts/{id}", (int id) =>
//{
//    return "Get a shirt by Id";
//});

app.Run();

