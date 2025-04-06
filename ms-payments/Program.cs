
using ms_payments.Services; 
using ms_payments.Controllers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
// Registrar el servicio en el contenedor de dependencias
builder.Services.AddScoped<IPaymentService, PaymentService>();


var app = builder.Build();

app.MapControllers();

app.Run();