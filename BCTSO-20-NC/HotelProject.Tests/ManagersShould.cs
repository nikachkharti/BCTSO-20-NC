using HotelProject.Models;
using HotelProject.Repository.MicrosoftDataSQLClient;

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
        public async void GetSingleManager()
        {
            var result = await _managerRepository.GetSingleManager(1);
        }

        [Fact]
        public async void AddNewManager()
        {
            Manager newManager = new()
            {
                FirstName = "ვალერი",
                LastName = "ზანგური",
                HotelId = 5
            };

            await _managerRepository.AddManager(newManager);
        }

        [Fact]
        public async void UpdateManager()
        {
            Manager newManager = new()
            {
                Id = 6,
                FirstName = "გიორგი",
                LastName = "გიორგაძე",
                HotelId = 5,
            };

            await _managerRepository.UpdateManager(newManager);
        }

        [Fact]
        public async void DeleteManager()
        {
            await _managerRepository.DeleteManager(6);
        }
    }
}
