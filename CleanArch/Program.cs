using CleanArch.Application.Contracts;
using CleanArch.Application.Services;
using CleanArch.Domain.Contracts;
using CleanArch.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUserRepository, UserRepository>();     // Infrastructure реализует Domain-интерфейс
builder.Services.AddScoped<IUserService, UserService>();          // Application

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.UseRouting();
app.MapControllers();
app.Run();