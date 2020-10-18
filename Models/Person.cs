using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace TechnicalTestWebApi.Models
{
    public class Person
    {
        [Key]
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

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
