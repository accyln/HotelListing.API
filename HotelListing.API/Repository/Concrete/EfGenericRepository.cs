using HotelListing.API.Data;
using HotelListing.API.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HotelListing.API.Repository.Concrete
{
    public class EfGenericRepository<T> : IGenericDal<T> where T : class
    {
        HotelListingDbContext dbContext;
        public EfGenericRepository(HotelListingDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<List<T>> GetAllAsync()
        {
            return await dbContext.Set<T>().ToListAsync();
            
        }

        public Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetAsync(int id)
        {
            return await dbContext.Set<T>().FindAsync();
        }
    }
}
