using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Soap;
using System.ServiceModel;

namespace Adapters.Services
{
    public class ClientSoapService : IClientSoapService
    {
        private readonly SoapClient _soapClient;
        private readonly IClientService _clientService;

        public ClientSoapService(SoapClient soapClient, IClientService clientService)
        {
            _soapClient = soapClient;
            _clientService = clientService;
        }

        public Client GetClientData(string clientId)
        {
            var xml = _soapClient.GetSoapResponse();
            return _clientService.GetClientFromSoapXml(xml);
        }
    }
}
