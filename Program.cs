using Aluraflix.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

string mySqlConnection = builder.Configuration.GetConnectionString("MySQLConnection");

builder.Services.AddDbContext<AppDbContext>(options => 
options.UseMySql(mySqlConnection, 
ServerVersion.AutoDetect(mySqlConnection)));

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
