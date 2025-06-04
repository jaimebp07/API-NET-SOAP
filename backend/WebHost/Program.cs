using Adapters.Services;
using Application.Interfaces;
using Infrastructure.Soap;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddScoped<IClientService, ClientService>();
builder.Services.AddSingleton<SoapClient>();

var app = builder.Build();
app.MapControllers();
app.Run();