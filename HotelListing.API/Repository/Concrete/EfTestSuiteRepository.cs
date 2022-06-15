using HotelListing.API.Data;
using HotelListing.API.Models;
using HotelListing.API.Repository.Abstract;

namespace HotelListing.API.Repository.Concrete
{
    public class EfTestSuiteRepository : EfGenericRepository<TestSuite>, ITestSuiteDal
    {
        private readonly HotelListingDbContext _context;
        public EfTestSuiteRepository(HotelListingDbContext dbContext) : base(dbContext)
        {
            _context = dbContext;   
        }
    }
}
