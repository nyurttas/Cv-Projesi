using System.Reflection;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Ymyp67CvBusiness.Abstract;
using Ymyp67CvBusiness.Concrete;
using Ymyp67CvBusiness.DependencyResolvers.Autofac;
using Ymyp67CvBusiness.Mappers.AutoMapper;
using Ymyp67CvDataAccess.Contexts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddCors(option =>
{
    option.AddPolicy("AllowAllOrigins", builder =>
        builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});

builder.Services.AddControllers();
builder.Services.AddDbContext<Ymyp67CvProjectDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("NesliHome"),
        options =>
        {
            options.MigrationsAssembly(Assembly.GetAssembly(typeof(Ymyp67CvProjectDbContext))!.GetName().Name);
        });
});

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory())
    .ConfigureContainer<ContainerBuilder>(builder =>
    {
        builder.RegisterModule(new AutofacBusinessModule());
    }
    );

builder.Services.AddAutoMapper(typeof(MapProfile).Assembly);


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

app.UseCors("AllowAllOrigins");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();