using System.ServiceModel;
using Domain.Entities;

namespace Application.Interfaces
{
    [ServiceContract]
    public interface IClientSoapService
    {
        [OperationContract]
        Client GetClientData(string clientId);
    }
}