using System.Linq.Expressions;

namespace HotelListing.API.Repository.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        Task<T> GetAsync(int id);
        Task<List<T>> GetAllAsync();
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter);

    }
}
