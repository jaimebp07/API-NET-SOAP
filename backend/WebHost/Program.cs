using Adapters.Services;
using Application.Interfaces;
using Infrastructure.Soap;
using SoapCore;
using System.ServiceModel.Channels;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngularClient", policy =>
    {
        policy.WithOrigins("http://localhost:4200")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

builder.Services.AddControllers().AddXmlSerializerFormatters();

builder.Services.AddScoped<IClientService, ClientService>();
builder.Services.AddScoped<IClientSoapService, ClientSoapService>();
builder.Services.AddSingleton<SoapClient>();

var app = builder.Build();

app.UseRouting();

app.UseCors("AllowAngularClient");

var binding = new CustomBinding(
    new TextMessageEncodingBindingElement(MessageVersion.Soap11, Encoding.UTF8),
    new HttpTransportBindingElement());

((IApplicationBuilder)app).UseSoapEndpoint<IClientSoapService>(
    "/Service.svc",
    binding,
    SoapSerializer.XmlSerializer);

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
