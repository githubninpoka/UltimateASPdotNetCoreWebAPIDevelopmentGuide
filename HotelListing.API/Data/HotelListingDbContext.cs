using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext :DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<Country> Country { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country()
                {
                    Id = 1,
                    Name = "Jamaica",
                    ShortName = "JM"
                },
                new Country()
                {
                    Id = 2,
                    Name = "Nederland",
                    ShortName = "NL"
                },
                new Country()
                {
                    Id = 3,
                    Name = "Deutschland",
                    ShortName = "GM"
                }
                );
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel()
                {
                    Id = 1,
                    Name = "Resort",
                    CountryId = 1,
                    Address = "beach 1",
                    Rating=4
                },
                new Hotel()
                {
                    Id = 2,
                    Name = "bilderberg",
                    CountryId = 2,
                    Address = "Apeldoorn",
                    Rating = 3
                },
                new Hotel()
                {
                    Id = 3,
                    Name = "wewelsburg",
                    CountryId = 3,
                    Address = "Paderborn",
                    Rating = 2
                }
                );
        }
    }
}
