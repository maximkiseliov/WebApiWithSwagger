﻿namespace TechnicalTestWebApi.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Locale { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Postcode { get; set; }
        public string CountryIsoCode { get; set; }

        public override string ToString()
        {
            return $"addressLine1: {AddressLine1}, locale: {Locale}";
        }
    }
}
