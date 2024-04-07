using HotelProject.Models;

namespace HotelProject.Repository.Interfaces
{
    public interface IRoomRepository
    {
        Task<List<Room>> GetRooms();
        Task<List<Room>> GetRoomsOfHotel(int hotelId);
        Task AddRoom(Room room);
        Task DeleteRoom(int id);
        Task UpdateRoom(Room room);
        Task<Room> GetSingleRoom(int id);
    }
}
