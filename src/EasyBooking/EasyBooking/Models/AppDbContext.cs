using Microsoft.EntityFrameworkCore;

namespace EasyBooking.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<AmbienteDev> AmbienteDevs { get; set; }

        public DbSet<Reserva> Reservas { get; set; }

    }
}
