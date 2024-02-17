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
            result.Type = Enum.Parse<Models.Type>(separatedData[5]);

            return result;
        }


        private static string ToCsv(Customer model)
        {
            return $"{model.Id},{model.Name},{model.IdentityNumber},{model.PhoneNumber},{model.Email},{model.Type}";
        }

        public void AddNewCustomer(Customer model)
        {
            if (model is null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            model.Id = _data.Max(x => x.Id) + 1;
            string result = ToCsv(model);
            Save(result);
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
            using (StreamWriter writer = new(_fileLocation, append: true))
            {
                writer.WriteLine($"\n{input}");
            }
        }
    }
}
