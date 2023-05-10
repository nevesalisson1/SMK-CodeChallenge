using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SMK.CrossCutting.AutoMapper;
using SMK.Domain.Implementations;
using SMK.Domain.Interfaces.BusinessLogic;
using SMK.Infrastructure.Context;

IMapper mapper = AutoMapperConfiguration.RegisterMappings().CreateMapper();

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Altera a localizacao padrao dos arquivos appsettings
var configDiretorio = Directory.GetCurrentDirectory() + "\\Config\\";
builder.Host.ConfigureAppConfiguration((hostingContext, config) =>
{
    config.AddJsonFile(configDiretorio + "appsettings.json",
                       optional: false,
                       reloadOnChange: true);

    config.AddJsonFile(configDiretorio + "appsettings.Development.json",
                       optional: false,
                       reloadOnChange: true);
});

builder.Services.AddHttpClient();

//RegistraSQLite
//builder.Services.AddDbContext<CargueiroContext>(options =>
//    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"))
//);

//Registra o AutoMapper
builder.Services.AddSingleton(mapper);

//Injecao de Depedencia
builder.Services.AddScoped<IFuctDomainService, FuctDomainService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
