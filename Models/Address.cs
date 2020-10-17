namespace TechnicalTestWebApi.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Locale { get; set; }
        public string AddressLine1 { get; set; }

        public override string ToString()
        {
            return $"addressLine1: {AddressLine1}, locale: {Locale}";
        }
    }
}
