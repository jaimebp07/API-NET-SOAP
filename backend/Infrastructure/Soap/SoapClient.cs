namespace Infrastructure.Soap
{
    public class SoapClient
    {
        public string GetSoapResponse()
        {
            // Dummy XML invalid balance
            //return @"<Client><CustomerName>Pepito Perez</CustomerName><TotalBalance>1234567890123456</TotalBalance><AccountStatus>Active</AccountStatus></Client>";
            // Dummy XML valid balance
            return @"<Client><CustomerName>Pepito Perez</CustomerName><TotalBalance>123456789</TotalBalance><AccountStatus>Active</AccountStatus></Client>";
            
        }
    }
}