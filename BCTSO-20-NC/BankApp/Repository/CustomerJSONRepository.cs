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
            //_data = Parse(File.ReadAllText(_fileLocation));

            using (StreamReader reader = new(_fileLocation))
            {
                string line = string.Empty;
                string x = string.Empty;
                while ((line = reader.ReadLine()) != null)
                {
                    //_data = Parse(line);
                    x += line;
                }
                _data = Parse(x);
            }

        }

        private static List<Customer> Parse(string input)
        {
            var result = JsonSerializer.Deserialize<List<Customer>>(input);
            return result;
        }


        private static string ToJson(Customer input)
        {
            string result = JsonSerializer.Serialize(input);
            return result;
        }

        public void AddNewCustomer(Customer model)
        {
            model.Id = _data.Max(x => x.Id) + 1;
            var result = ToJson(model);
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
            if (!input.StartsWith("{") || !input.EndsWith("}"))
                throw new FormatException("Invalid json format");

            string existingJson = File.ReadAllText(_fileLocation);

            existingJson = existingJson.TrimEnd(']');
            input = $",{input}";

            File.WriteAllText(_fileLocation, $"{existingJson}{input}]");
        }
    }
}
