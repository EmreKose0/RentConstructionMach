using RentConstructionMach.Persistence.Context;
using RentConstructionMach.Application.Services;
using RentConstructionMach.Application.Interfaces;
using RentConstructionMach.Persistence.Repositories;
using RentConstructionMach.Application.Interfaces.TagCloudInterfaces;
using RentConstructionMach.Persistence.Repositories.TagCloudRepositories;
using RentConstructionMach.Application.Interfaces.MachineInterfaces;
using RentConstructionMach.Persistence.Repositories.MachinePricingRepositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using RentConstructionMach.Application.Tools;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHttpClient();
builder.Services.AddCors(opt =>
{
    opt.AddPolicy("CorsPolicy", builder =>
    {
        builder.AllowAnyHeader()
        .AllowAnyMethod()
        .SetIsOriginAllowed((host) => true)
        .AllowCredentials();
    });
}); //API taraf?nda frontend taraf?nda SignalR ile tüketmeye izin veriyor
builder.Services.AddSignalR();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt =>
{
    opt.RequireHttpsMetadata = false;
    opt.TokenValidationParameters = new TokenValidationParameters
    {
        ValidAudience = JwtTokenDefauls.ValidAudience,    //JWT yi yürütücek taraf
        ValidIssuer = JwtTokenDefauls.ValidIssuer,      //JWT yi olusturan kurulus
        ClockSkew = TimeSpan.Zero,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtTokenDefauls.Key)),  //olusturulan sifre
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,

    };
});


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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
