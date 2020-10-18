using System;
using System.ComponentModel.DataAnnotations;

namespace TechnicalTestWebApi.Models
{
    public class Registration
    {
        [Key]
        public Guid RegistrationId { get; set; }

        [Required]
        public DateTime RegistrationDate { get; set; }

        public string Locale { get; set; }

        [Required]
        public Person Person { get; set; }

        public Organisation Organisation { get; set; }
    }
}
