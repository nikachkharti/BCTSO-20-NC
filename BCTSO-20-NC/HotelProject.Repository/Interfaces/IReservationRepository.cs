using HotelProject.Models;

namespace HotelProject.Repository.Interfaces
{
    public interface IReservationRepository
    {
        Task<List<Reservation>> GetAll();
        Task<Reservation> GetById(int id);
        Task<Reservation> GetByCheckInCheckOutDate(DateTime checkinDate, DateTime checkoutDate);
        Task Add(Reservation guest);
        Task Update(Reservation guest);
        Task Delete(int id);
    }
}
