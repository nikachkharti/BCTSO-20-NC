using BankApp.Models;
using BankApp.Repository.Interfaces;
using System.Text.Json;


namespace BankApp.Repository
{
    public class CustomerJSONRepository : IRepository
    {
        private const string _fileLocation = "C:\\Users\\User\\Desktop\\IT STEP\\BCTSO-20-NC\\BCTSO-20-NC\\BankApp\\Customers.json";
        List<Customer> _data = new();

        public CustomerJSONRepository()
        {
            _data = Parse(File.ReadAllText(_fileLocation));
        }

        private static List<Customer> Parse(string input)
        {
            var result = JsonSerializer.Deserialize<List<Customer>>(input);
            return result;
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
    }
}
