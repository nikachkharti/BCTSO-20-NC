using HotelProject.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public static string ConnectionString { get; } = "Server=DESKTOP-SCSHELD\\SQLEXPRESS;Database=DOITHotel_BCTSO;Trusted_Connection=True;TrustServerCertificate=True";

        public DbSet<Hotel> Hotels { get; set; }
    }
}
