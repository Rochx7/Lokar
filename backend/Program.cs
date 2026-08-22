using Lokar.Data;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
builder.Services.AddOpenApi();

var app = builder.Build();

if (builder.Environment.IsDevelopment())
{
  app.MapScalarApiReference();
  app.MapOpenApi();
}

app.MapControllers();

app.Run();
