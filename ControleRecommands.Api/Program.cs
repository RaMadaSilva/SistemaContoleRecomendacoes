using ControleRecomands.Infra.Context;
using ControleRecomands.Infra.Repositories;
using ControleRecomands.Infra.Repositories.UniteOfWork;
using ControleRecommads.Domain.Commands;
using ControleRecommads.Domain.Commands.Interfaces;
using ControleRecommads.Domain.Entities;
using ControleRecommads.Domain.Entities.ValueObject;
using ControleRecommads.Domain.Handler;
using ControleRecommads.Domain.Handler.Interface;
using ControleRecommads.Domain.IRepositories;
using ControleRecommads.Domain.IRepositories.IUniteOfWork;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddControllers();
var connetions = builder.Configuration.GetConnectionString("connectionDb");

builder.Services.AddDbContext<RecommendationDbContext>(options => options.UseSqlServer(connetions));
builder.Services.AddTransient<IUniteOfWork, UniteOfWork>();
builder.Services.AddTransient<IHandler<ReceiveCommand>, ReceivedRecommendationHandler>();
builder.Services.AddTransient<IHandler<RetornRecommendationCommand>, ReceivedRecommendationHandler>();
builder.Services.AddScoped<ICommandResult, CommandResult>(); 
builder.Services.AddTransient<IRepositoryBase<ReceivedRecommendation>, RepositoryBase<ReceivedRecommendation>>();
builder.Services.AddTransient<IEntityRepository<Member>, EntityRepository<Member>>();
builder.Services.AddTransient<IEntityRepository<Church>,  EntityRepository<Church>>();
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
