using HotelListing.API.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext:DbContext
    {

        public HotelListingDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<TestSuite> TestSuites { get; set; }
    }
}
