using AutoMapper;
using SMK.CrossCutting.AutoMapper;
using SMK.Domain.Implementations;
using SMK.Domain.Interfaces;

IMapper mapper = AutoMapperConfiguration.RegisterMappings().CreateMapper();

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Registra o AutoMapper
builder.Services.AddSingleton(mapper);

//Injeção de Depedência
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
