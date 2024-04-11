using HotelProject.Models;

namespace HotelProject.Repository.Interfaces
{
    public interface IHotelRepository
    {
        Task<List<Hotel>> GetHotels();
        Task<Hotel> GetSingleHotel(int id);
        Task AddHotel(Hotel hotel);
        Task UpdateHotel(Hotel hotel);
        Task DeleteHotel(int id);
        Task<List<Hotel>> GetHotelsWithoutManager();
    }
}
