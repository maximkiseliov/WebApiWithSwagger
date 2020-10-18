using Microsoft.EntityFrameworkCore;
using TechnicalTestWebApi.Models;

namespace TechnicalTestWebApi.DB
{
    public class RegistrationAppDbContext : DbContext
    {
        public RegistrationAppDbContext(DbContextOptions<RegistrationAppDbContext> options) : base(options)
        {
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Organisation> Organisations { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Registration> Registrations { get; set; }
    }
}
