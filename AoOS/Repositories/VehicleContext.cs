using AoOS.Models;
using Microsoft.EntityFrameworkCore;

namespace AoOS.Repositories
{
    public class VehicleContext : DbContext
    {
        public VehicleContext() { }

        public VehicleContext(DbContextOptions<VehicleContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSnakeCaseNamingConvention();

        public virtual DbSet<Vehicle> vehicles { get; set; }
    }
}
