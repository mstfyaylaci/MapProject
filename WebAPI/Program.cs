using Business.Abstract;
using Business.Concrete;

using DataAccess.Abstract;
using DataAccess.Concrete.Context;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.Json;
using Microsoft.EntityFrameworkCore;
using Npgsql;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddCors();

builder.Services.AddSingleton<IPointService, PointManager>();
builder.Services.AddSingleton<IPointDal, JsPoint>(); // 

builder.Services.AddSingleton<IPolygonService, PolygonManager>();
builder.Services.AddSingleton<IPolygonDal, JsPolygon>(); // 



//var dataSourceBuilder = new NpgsqlDataSourceBuilder("Server=localhost;Port=5432;DataBase=MapProject; User Id=postgres; password=1201");
//dataSourceBuilder.UseNetTopologySuite();
//var dataSource = dataSourceBuilder.Build();

//// Then, when configuring EF Core with UseNpgsql(), call UseNetTopologySuite() there as well:
//builder.Services.AddDbContext<MapContext>(options =>
//    options.UseNpgsql(dataSource,UseNetTopologySuite()));


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
    });
}
app.UseCors(builder=>builder.WithOrigins("http://localhost:4201").AllowAnyMethod().AllowAnyHeader());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
