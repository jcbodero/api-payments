using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using System.IO;

var builder = WebApplication.CreateBuilder(args);

// Configuración de Ocelot en los servicios
builder.Configuration.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);

builder.Services.AddOcelot(); 
var app = builder.Build();

await app.UseOcelot();

app.Run();
