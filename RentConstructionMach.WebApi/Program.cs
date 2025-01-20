using RentConstructionMach.Persistence.Context;
using RentConstructionMach.Application.Services;
using RentConstructionMach.Application.Interfaces;
using RentConstructionMach.Persistence.Repositories;
using RentConstructionMach.Application.Interfaces.TagCloudInterfaces;
using RentConstructionMach.Persistence.Repositories.TagCloudRepositories;
using RentConstructionMach.Application.Interfaces.MachineInterfaces;
using RentConstructionMach.Persistence.Repositories.MachinePricingRepositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHttpClient();

builder.Services.AddScoped<RentConstructionMachContext>();

builder.Services.AddApplicationService(builder.Configuration);
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped(typeof(ITagCloudRepository), typeof(TagCloudRepository));
builder.Services.AddScoped(typeof(IMachinePricingRepository), typeof(MachinePricingRepository));



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

app.UseAuthorization();

app.MapControllers();

app.Run();
