using Microsoft.EntityFrameworkCore;
using PetApp.Core.Interfaces.Repositories;
using PetApp.Core.Interfaces.Services;
using PetApp.Core.Services;
using PetApp.Infra.Data;
using PetApp.Infra.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddDbContext();

//Configure DB
var connString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<PetDbContext>(option => option.UseSqlServer(connString));




//container de versao de controle IOC
// AddScoped limpa da memoria apos resolve
builder.Services.AddScoped<IEspecieService, EspecieService>();
builder.Services.AddScoped<IEspecieRepository, EspecieRepository>();


//singleton não limpa da memoria

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
