using CatTail.API.Data;
using CatTail.API.Models;
using CatTail.API.Repository;
using CatTail.API.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// add dbcontext with connection string
builder.Services.AddDbContext<CatContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CatTail")));

// add service dependencies
builder.Services.AddScoped<ICatService, CatService>();

// add repo dependencies
builder.Services.AddScoped<ICatRepository, CatRepository>();

// add controllers
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// map controllers
app.MapControllers();

app.Run();
