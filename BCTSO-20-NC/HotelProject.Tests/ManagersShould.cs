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
        public void GetManagers()
        {
            var result = _managerRepository.GetManagers();
        }

        [Fact]
        public void AddNewManager()
        {
            Manager newManager = new()
            {
                FirstName = "Test",
                LastName = "Test"
            };

            _managerRepository.AddManager(newManager);
        }
    }
}
