using BankApp.Models;
using BankApp.Repository.Interfaces;

namespace BankApp.Repository
{
    public class CustomerCSVRepository : IRepository
    {
        private const string _fileLocation = "C:\\Users\\User\\Desktop\\IT STEP\\BCTSO-20-NC\\BCTSO-20-NC\\BankApp\\Customers.csv";
        List<Customer> _data = new();

        public CustomerCSVRepository()
        {
            _data = File.ReadLines(_fileLocation)
                .Skip(1)
                .Select(Parse)
                .ToList();
        }

        private static Customer Parse(string input)
        {
            var separatedData = input.Split(',');

            if (separatedData.Length != 6)
            {
                throw new FormatException("Incorrect format");
            }

            Customer result = new();

            result.Id = int.Parse(separatedData[0]);
            result.Name = separatedData[1];
            result.IdentityNumber = separatedData[2];
            result.PhoneNumber = separatedData[3];
            result.Email = separatedData[4];
            result.Type = int.Parse(separatedData[5]);

            return result;
        }

        public void AddNewCustomer(Customer model)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAllCustomers()
        {
            return _data;
        }

        public Customer GetSingleCustomer(int id)
        {
            var result = _data.FirstOrDefault(x => x.Id == id);

            if (result == null)
            {
                throw new NullReferenceException("Data not found");
            }

            return result;
        }

        public void Save(string input)
        {
            throw new NotImplementedException();
        }
    }
}
