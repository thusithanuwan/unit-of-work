using Microsoft.EntityFrameworkCore;
using UnitOfWork.Data;
using UnitOfWork.Repository;
using UnitOfWork.Repository.Repository;
using UnitOfWork.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// var connectionString = builder.Configuration.GetConnectionString("connection");
// builder.Services.AddDbContext<Context>(option =>
//     option.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

// builder.Services.AddScoped<IStudentUnitOfWork, StudentUnitOfWork>();


var connectionString = builder.Configuration.GetConnectionString("connection");
builder.Services.AddDbContext<Context>(option =>
    option.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
        
builder.Services.AddScoped<IStudentUnitOfWork, StudentUnitOfWork>();
builder.Services.AddScoped<IStudentService, StudentService>();

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