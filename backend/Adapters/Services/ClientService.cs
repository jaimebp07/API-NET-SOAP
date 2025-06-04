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

            var digitsOnly = new string(balanceRaw?.Where(char.IsDigit).ToArray());

            if (string.IsNullOrEmpty(digitsOnly))
                throw new FormatException("TotalBalance está vacío o mal formado.");

            if (digitsOnly.Length > 15)
                throw new InvalidOperationException("TotalBalance excede los 15 dígitos permitidos.");

            if (!decimal.TryParse(balanceRaw, out var balanceValue))
                throw new FormatException("Formato inválido en TotalBalance.");

            return new Client
            {
                CustomerName = name ?? "N/A",
                TotalBalance = new Balance(balanceValue),
                AccountStatus = status ?? "Unknown"
            };
        }
    }
}
