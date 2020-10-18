using System.ComponentModel.DataAnnotations;

namespace TechnicalTestWebApi.Models
{
    public class Person
    {
        public int PersonId { get; set; }

        [Required]
        [MaxLength(150)]
        [MinLength(1)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(150)]
        [MinLength(1)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(150)]
        [MinLength(1)]
        public string Email { get; set; }

        public Address Address { get; set; }
    }
}
