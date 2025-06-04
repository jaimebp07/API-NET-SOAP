using Application.Interfaces;
using Domain.Entities;
using Domain.ValueObjects;
using System.Xml.Linq;

namespace Adapters.Services
{
    public class ClientService : IClientService
    {
        public Client GetClientFromSoapXml(string xml)
        {
            var doc = XDocument.Parse(xml);
            var name = doc.Descendants("CustomerName").FirstOrDefault()?.Value;
            var balanceRaw = doc.Descendants("TotalBalance").FirstOrDefault()?.Value;
            var status = doc.Descendants("AccountStatus").FirstOrDefault()?.Value;

            if (!decimal.TryParse(balanceRaw, out var balanceValue))
                throw new FormatException("Invalid balance format");

            return new Client
            {
                CustomerName = name,
                TotalBalance = new Balance(balanceValue),
                AccountStatus = status
            };
        }
    }
}