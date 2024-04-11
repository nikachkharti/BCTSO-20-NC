using HotelProject.Data;
using HotelProject.Models;
using HotelProject.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HotelProject.Repository
{
    public class ManagerRepositoryEF : IManagerRepository
    {
        private readonly ApplicationDbContext _context;
        public ManagerRepositoryEF(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddManager(Manager manager)
        {
            if (manager is null)
            {
                throw new ArgumentNullException("Invalid argument passed");
            }

            await _context.Managers.AddAsync(manager);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteManager(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentNullException("Invalid argument passed");
            }

            var entity = await _context.Managers.FirstAsync(h => h.Id == id);

            _context.Managers.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Manager>> GetManagers()
        {
            var entities = await _context.Managers
                .Include(nameof(Hotel))
                .ToListAsync();

            if (entities == null)
            {
                throw new NullReferenceException("Entities not  found");
            }

            return entities;
        }

        public async Task<Manager> GetSingleManager(int id)
        {
            var entity = await _context.Managers
                .Include(nameof(Hotel))
                .FirstAsync(h => h.Id == id);
            return entity;
        }

        public async Task UpdateManager(Manager manager)
        {
            if (manager.Id <= 0 || manager == null)
            {
                throw new ArgumentNullException("Invalid argument passed");
            }

            var entity = await _context.Managers.FirstAsync(m => m.Id == manager.Id);

            entity.FirstName = manager.FirstName;
            entity.LastName = manager.LastName;
            if (manager.HotelId == 0)
            {
                manager.HotelId = entity.HotelId;
            }

            _context.Managers.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
