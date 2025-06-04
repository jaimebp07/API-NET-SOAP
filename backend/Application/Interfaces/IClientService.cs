using Domain.Entities;

namespace Application.Interfaces
{
    public interface IClientService
    {
        Client GetClientFromSoapXml(string xml);
    }
}