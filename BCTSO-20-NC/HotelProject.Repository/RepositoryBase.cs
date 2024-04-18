using HotelProject.Data;
using HotelProject.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HotelProject.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private DbSet<T> _dbSet;
        public RepositoryBase(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public Task AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> GetAllAsync(Func<T, bool> filter, string includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> GetAllAsync(string includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetAsync(Func<T, bool> filter, string includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
