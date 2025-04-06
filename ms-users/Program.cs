
using ms_users.Services; 
using ms_users.Controllers;
using System.Reflection;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
// Registrar el servicio en el contenedor de dependencias
builder.Services.AddServices(Assembly.GetExecutingAssembly());


var app = builder.Build();

app.MapControllers();

app.Run();