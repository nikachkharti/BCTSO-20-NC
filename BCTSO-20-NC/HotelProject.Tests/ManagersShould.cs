using HotelProject.Models;
using HotelProject.Repository;

namespace HotelProject.Tests
{
    public class ManagersShould
    {
        private readonly ManagerRepository _managerRepository;
        public ManagersShould()
        {
            _managerRepository = new();
        }


        [Fact]
        public async void GetManagers()
        {
            var result = await _managerRepository.GetManagers();
        }

        [Fact]
        public async void AddNewManager()
        {
            Manager newManager = new()
            {
                FirstName = "ალექსანდრე",
                LastName = "ამოევი",
                HotelId = 3
            };

            await _managerRepository.AddManager(newManager);
        }

        [Fact]
        public async void UpdateManager()
        {
            Manager newManager = new()
            {
                Id = 1,
                FirstName = "გიორგი",
                LastName = "გიორგაძე",
                HotelId = 1,
            };

            await _managerRepository.UpdateManager(newManager);
        }

        [Fact]
        public async void DeleteManager()
        {
            await _managerRepository.DeleteManager(4);
        }
    }
}
