using HotelProject.Models;
using HotelProject.Repository.Interfaces;

namespace HotelProject.Repository
{
    public class ReservationRepositoryEF : IReservationRepository
    {
        public Task Add(Reservation guest)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Reservation>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Reservation> GetByCheckInCheckOutDate(DateTime checkinDate, DateTime checkoutDate)
        {
            throw new NotImplementedException();
        }

        public Task<Reservation> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Reservation guest)
        {
            throw new NotImplementedException();
        }
    }
}
