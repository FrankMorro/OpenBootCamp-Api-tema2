using Microsoft.EntityFrameworkCore;
using Tema2_Ejercicio1_Curso.DataAccess;

var builder = WebApplication.CreateBuilder(args);

const string CONNECTIONNAME = "CursoOPDB";
var connectiongString = builder.Configuration.GetConnectionString(CONNECTIONNAME);
builder.Services.AddDbContext<CursoOBDBContext>(options => options.UseSqlServer(connectiongString));

// Add services to the container.

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
