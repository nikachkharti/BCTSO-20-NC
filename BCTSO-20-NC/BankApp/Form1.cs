using BankApp.Models;
using BankApp.Repository;
using BankApp.Repository.Interfaces;
using Type = BankApp.Models.Type;

namespace BankApp
{
    public partial class Form1 : Form
    {
        private readonly IRepository _repository;

        public Form1(IRepository repository)
        {
            InitializeComponent();
            _repository = repository;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                var result = _repository.GetAllCustomers();
                dataList.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "დაფიქსირდა შეცდომა");
            }
        }

        private void dataList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = dataList.SelectedItem as Customer;

                if (selectedItem != null)
                {
                    nameValue.Text = selectedItem.Name;
                    identityNumberValue.Text = selectedItem.IdentityNumber;
                    phoneValue.Text = selectedItem.PhoneNumber;
                    emailValue.Text = selectedItem.Email;
                    typeValue.Text = selectedItem.Type.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "დაფიქსირდა შეცდომა");
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var newCustomer = GetObject();
                _repository.AddNewCustomer(newCustomer);

                var result = _repository.GetAllCustomers();
                dataList.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "დაფიქსირდა შეცდომა");
            }

        }


        private Customer GetObject()
        {
            Customer result = new();
            result.Name = nameValue.Text;
            result.IdentityNumber = identityNumberValue.Text;
            result.PhoneNumber = phoneValue.Text;
            result.Email = emailValue.Text;
            result.Type = Enum.Parse<Type>(typeValue.Text);

            return result;
        }
    }
}
