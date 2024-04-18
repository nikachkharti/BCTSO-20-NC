using System.Linq.Expressions;

namespace HotelProject.Repository.Interfaces
{
    public interface IRepositoryBase<T> where T : class
    {
        Task<List<T>> GetAllAsync(Func<T, bool> filter, string includeProperties = null);
        Task<List<T>> GetAllAsync(string includeProperties = null);
        Task<T> GetAsync(Func<T, bool> filter, string includeProperties = null);
        Task AddAsync(T entity);
        Task RemoveAsync(T entity);
    }
}
