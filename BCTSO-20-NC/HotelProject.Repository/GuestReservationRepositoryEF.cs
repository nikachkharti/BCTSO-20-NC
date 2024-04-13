using HotelProject.Models;
using HotelProject.Repository.Interfaces;

namespace HotelProject.Repository
{
    public class GuestReservationRepositoryEF : IGuestReservationRepository
    {
        public Task Add(GuestReservation guest)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<GuestReservation>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<GuestReservation> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(GuestReservation guest)
        {
            throw new NotImplementedException();
        }
    }
}
