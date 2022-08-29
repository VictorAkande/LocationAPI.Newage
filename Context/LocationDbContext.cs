using LocationAPI.Newage.Models;
using Microsoft.EntityFrameworkCore;

namespace LocationAPI.Newage.Context
{
    public class LocationDbContext : DbContext
    {
        public LocationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<City> cities { get; set; }

    }
}
