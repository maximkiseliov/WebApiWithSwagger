using System.ComponentModel.DataAnnotations;

namespace TechnicalTestWebApi.Models
{
    public class Organisation
    {
        public int OrganisationId { get; set; }

        [Required]
        [MaxLength(120)]
        [MinLength(1)]
        public string Name { get; set; }

        [Required]
        public Address Address { get; set; }
    }
}
