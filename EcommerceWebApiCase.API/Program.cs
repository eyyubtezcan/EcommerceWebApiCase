using EcommerceWebApiCase.Data;
using EcommerceWebApiCase.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.



builder.Services.AddScoped<DbContext, EcommerceDbContext>();
builder.Services.AddDbContext<EcommerceDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration["ConnectionStrings:SqlConStr"].ToString(), o =>
    {
        o.MigrationsAssembly("EcommerceWebApiCase.Data");
    });
});

builder.Services.AddScoped(typeof(IService<>), typeof(Service<>));


#region Services
builder.Services.AddScoped<IProductService, ProductService>();

#endregion


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
