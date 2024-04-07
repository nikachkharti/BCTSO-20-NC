using HotelProject.Models;

namespace HotelProject.Repository.Interfaces
{
    public interface IManagerRepository
    {
        Task<List<Manager>> GetManagers();
        Task<Manager> GetSingleManager(int id);
        Task AddManager(Manager manager);
        Task UpdateManager(Manager manager);
        Task DeleteManager(int id);
    }
}
