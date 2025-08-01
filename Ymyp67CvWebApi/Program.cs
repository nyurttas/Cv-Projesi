using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Ymyp67CvDataAccess.Contexts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<Ymyp67CvProjectDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("NesliHome"),
        options=>
    {
        options.MigrationsAssembly(Assembly.GetAssembly(typeof(Ymyp67CvProjectDbContext))!.GetName().Name);
        
    });
});
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
