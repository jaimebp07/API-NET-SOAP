using Application.Interfaces;
using Infrastructure.Soap;
using Microsoft.AspNetCore.Mvc;

namespace WebHost.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/xml")]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;
        private readonly SoapClient _soapClient;

        public ClientController(IClientService clientService, SoapClient soapClient)
        {
            _clientService = clientService;
            _soapClient = soapClient;
        }

        [HttpGet("balance")]
        public ActionResult GetClientBalance()
        {
            var xml = _soapClient.GetSoapResponse();
            var client = _clientService.GetClientFromSoapXml(xml);

            return Ok(client);
        }
    }
}
