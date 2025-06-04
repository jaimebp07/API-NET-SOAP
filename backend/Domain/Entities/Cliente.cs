using Domain.ValueObjects;

namespace Domain.Entities
{
    public class Client
    {
        public string CustomerName { get; set; }
        public Balance TotalBalance { get; set; }
        public string AccountStatus { get; set; }
    }
}