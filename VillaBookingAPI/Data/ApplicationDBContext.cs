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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa
                {
                    Id = 1,
                    Name = "Royal Villa",
                    Details = "A luxurious villa with all amenities.",
                    Rate = 200.00,
                    Occupancy = 4,
                    Sqft = 1500,
                    ImageUrl = "https://example.com/royal-villa.jpg",
                    Amenity = "Pool, WiFi, Breakfast",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                }
            );
        }
    }
    {
    }
}
