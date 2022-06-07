using AP2POO.Models.Domains;
using AP2POOFER.Models.Domains;
using Microsoft.EntityFrameworkCore;

namespace AP2POO.Models.Repositories
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opts)
            :base(opts)
        {}

        public DbSet<Person> People { get; set; }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}