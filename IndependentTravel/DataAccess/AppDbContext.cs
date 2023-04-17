using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using IndependentTravel.DataModels;

namespace IndependentTravel.DataAccess
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Destination> Destinations { get; set; }
    }
}
