using System.ComponentModel.DataAnnotations;

namespace TechnicalTestWebApi.Models
{
    public class Address
    {
        public int AddressId { get; set; }

        public string Locale { get; set; }

        [Required]
        [MaxLength(150)]
        [MinLength(1)]
        public string AddressLine1 { get; set; }

        [MaxLength(150)]
        public string AddressLine2 { get; set; }

        [MaxLength(150)]
        public string AddressLine3 { get; set; }

        [MaxLength(40)]
        public string City { get; set; }

        [MaxLength(60)]
        public string State { get; set; }

        [MaxLength(60)]
        public string Postcode { get; set; }

        [Required]
        [MaxLength(60)]
        public string CountryIsoCode { get; set; }

        public override string ToString()
        {
            return $"addressLine1: {AddressLine1}, locale: {Locale}";
        }
    }
}
