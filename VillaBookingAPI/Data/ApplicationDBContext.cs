using Microsoft.EntityFrameworkCore;
using VillaBookingAPI.Models;

namespace VillaBookingAPI.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
        public DbSet<Villa> Villas { get; set; }          
    }
}
