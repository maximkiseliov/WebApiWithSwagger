using Microsoft.EntityFrameworkCore;
using TechnicalTestWebApi.Models;

namespace TechnicalTestWebApi
{
    public class RegistrationAppDbContext : DbContext
    {
        public RegistrationAppDbContext(DbContextOptions<RegistrationAppDbContext> options) : base(options)
        {
        }

        public DbSet<Address> Addresses { get; set; }
    }
}
