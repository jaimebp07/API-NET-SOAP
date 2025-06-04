using Adapters.Services;
using Application.Interfaces;
using Infrastructure.Soap;
using SoapCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddScoped<IClientService, ClientService>();
builder.Services.AddSingleton<SoapClient>();
builder.Services.AddSingleton<IClientSoapService, ClientSoapService>();

var app = builder.Build();

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.UseSoapEndpoint<IClientSoapService>("/Service.svc", new SoapEncoderOptions(), SoapSerializer.DataContractSerializer);
});

app.MapControllers();
app.Run();