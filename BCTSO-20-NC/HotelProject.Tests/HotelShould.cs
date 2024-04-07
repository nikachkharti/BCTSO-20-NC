using HotelProject.Models;
using HotelProject.Repository.MicrosoftDataSQLClient;

namespace HotelProject.Tests
{
    public class HotelShould
    {
        private readonly HotelRepository _hotelRepository;
        public HotelShould()
        {
            _hotelRepository = new();
        }


        [Fact]
        public async void Get_Hotels()
        {
            var result = await _hotelRepository.GetHotels();
        }

        [Fact]
        public async void Get_Single_Hotel()
        {
            var result = await _hotelRepository.GetSingleHotel(1);
        }

        [Fact]
        public async void Add_New_Hotel_In_Database()
        {
            Hotel newHotel = new()
            {
                Name = "Radisson",
                Rating = 9.5,
                Country = "საქართველო",
                City = "თბილისი",
                PhyisicalAddress = "ვარდების მოედანი"
            };

            await _hotelRepository.AddHotel(newHotel);
        }

        [Fact]
        public async void Update_Hotel_In_Database()
        {
            Hotel newHotel = new()
            {
                Id = 4,
                Name = "Marriot",
                Rating = 9.5,
                Country = "საქართველო",
                City = "თბილისი",
                PhyisicalAddress = "ვარდების მოედანი"
            };

            await _hotelRepository.UpdateHotel(newHotel);
        }


        [Fact]
        public async void Delete_Hotel_From_Database()
        {
            await _hotelRepository.DeleteHotel(4);
        }
    }
}
