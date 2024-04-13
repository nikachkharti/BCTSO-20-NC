using HotelProject.Models;
using HotelProject.Repository.Interfaces;

namespace HotelProject.Repository
{
    public class GuestRepositoryEF : IGuestRepository
    {
        public Task Add(Guest guest)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Guest>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Guest> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Guest> GetByPin(string personalNumber)
        {
            throw new NotImplementedException();
        }

        public Task Update(Guest guest)
        {
            throw new NotImplementedException();
        }
    }
}
