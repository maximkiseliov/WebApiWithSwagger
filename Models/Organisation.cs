using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace TechnicalTestWebApi.Models
{
    public class Organisation
    {
        [Key]
        public int OrganisationId { get; set; }

        [Required]
        [MaxLength(120)]
        [MinLength(1)]
        public string Name { get; set; }

        [Required]
        public Address Address { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
