namespace Infrastructure.Soap
{
    public class SoapClient
    {
        public string GetSoapResponse()
        {
            // Dummy XML response for testing
            return @"<Client><CustomerName>Pepito Perez</CustomerName><TotalBalance>123456.78</TotalBalance><AccountStatus>Active</AccountStatus></Client>";
        }
    }
}