using BankApp.Models;
using BankApp.Repository.Interfaces;
using System.Xml;
using Type = BankApp.Models.Type;

namespace BankApp.Repository
{
    public class CustomerXMLRepository : IRepository
    {
        private const string _fileLocation = "C:\\Users\\User\\Desktop\\IT STEP\\BCTSO-20-NC\\BCTSO-20-NC\\BankApp\\Customers.xml";
        List<Customer> _data = new();

        public CustomerXMLRepository()
        {
            _data = Parse(File.ReadAllText(_fileLocation));
        }

        private static List<Customer> Parse(string input)
        {
            List<Customer> result = new();

            XmlDocument xmlDoc = new();
            xmlDoc.LoadXml(input);

            XmlNodeList customerNodes = xmlDoc.SelectNodes("//Customer");

            foreach (XmlNode node in customerNodes)
            {
                Customer newCustomer = new();

                newCustomer.Id = int.Parse(node.SelectSingleNode("Id").InnerText);
                newCustomer.Name = node.SelectSingleNode("Name").InnerText;
                newCustomer.IdentityNumber = node.SelectSingleNode("IdentityNumber").InnerText;
                newCustomer.PhoneNumber = node.SelectSingleNode("PhoneNumber").InnerText;
                newCustomer.Email = node.SelectSingleNode("Email").InnerText;
                newCustomer.Type = Enum.Parse<Type>(node.SelectSingleNode("Type").InnerText);

                result.Add(newCustomer);
            }

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
