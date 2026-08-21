using Microsoft.EntityFrameworkCore;
using Projekt.Aplication.Interfaces;
using Projekt.Aplication.Services;
using Projekt.DAL.Repositories;
using Projekt.Domain.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ISportCentarService, SportCentarService>();
builder.Services.AddScoped<ISportCentarRepository, SportCentarRepository>();
builder.Services.AddScoped<ITerrainService, TerrainService>();
builder.Services.AddScoped<ITerrainRepository, TerrainRepository>();
builder.Services.AddScoped<ISportTypeRepository, SportTypeRepository>();
builder.Services.AddScoped<ISportTypeService, SportTypeService>();
builder.Services.AddScoped<IReservationRepository,  ReservationRepository>();
builder.Services.AddScoped<IReservationService, ReservationService>();
builder.Services.AddScoped<IReviewRepository, ReviewRepository>();
builder.Services.AddScoped<IReviewService, ReviewService>();

builder.Services.AddDbContext<Projekt.DAL.Data.ProjektContext>
    (options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


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

app.UseAuthorization();

app.MapControllers();

app.Run();
