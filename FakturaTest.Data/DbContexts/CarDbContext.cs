using FakturaTest.Domains.Entities;
using Microsoft.EntityFrameworkCore;

namespace FakturaTest.Data.DbContexts
{
    public class CarDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public CarDbContext(DbContextOptions<CarDbContext> options) : base(options)
        {
        }
    }
}
