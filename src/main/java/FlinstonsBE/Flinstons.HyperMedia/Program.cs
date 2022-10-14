using FlinstonBE.Application.Users.Handlers;
using FlinstonBE.Application.Users.Handlers.Protocols;
using Flinstons.HyperMedia.Repositories;
using FlinstonsBE.Data.Repositories;
using FlinstonsBE.Data.UseCase;
using FlinstonsBE.Domain.Users.UseCase;
using FlinstonsBE.Infrastructure.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<BackEndDataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("FlinstonsDB")));

builder.Services.AddScoped<ICreateUserRepository, CreateUserRepository>();
builder.Services.AddScoped<ICreateUserUseCase, CreateUserUseCase>();
builder.Services.AddScoped<ICreateUserHandler, CreateUserHandler>();

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