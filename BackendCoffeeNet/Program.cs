using BackendCoffeeNet.Data;
using Microsoft.EntityFrameworkCore;
using BackendCoffeeNet.Data.Repository;
using BackendCoffeeNet.Models;
using BackendCoffeeNet.Data.Repository.IRepository;
using Microsoft.AspNetCore.Identity;
using BackendCoffeeNet.Services.Contracts;
using BackendCoffeeNet.Services.Implementations;

var builder = WebApplication.CreateBuilder(args);


// MARCO
// var conectionString = builder.Configuration.GetConnectionString("ConexionSQL") ?? throw new InvalidOperationException("Connection string 'ConexionSQL' not found.");
// builder.Services.AddDbContext<ApplicationDBContext>(options =>
//     options.UseSqlServer(conectionString));

//LUIS
 var conectionString2 = builder.Configuration.GetConnectionString("ConexionSQL2") ?? throw new InvalidOperationException("Connection string 'ConexionSQL' not found.");
 builder.Services.AddDbContext<ApplicationDBContext>(options =>
     options.UseSqlServer(conectionString2));



// Servicio para Hash
builder.Services.AddTransient<IPasswordHasher<Usuarios>, PasswordHasher<Usuarios>>();

// Repositorios
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
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
app.MapControllers();



app.Run();

