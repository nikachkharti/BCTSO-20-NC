namespace BankDesktopApplication
{
    public partial class Form1 : Form
    {
        public List<Person> People = new()
        {
            new Person()
            {
                Name ="Nika",
                 Age = 10,
            },
            new Person()
            {
                Name ="Girogi",
                 Age = 30,
            },
            new Person()
            {
                Name ="Daviti",
                 Age = 20,
            }
        };


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in People)
            {
                peopleList.Items.Add(item);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Person newPerson = new()
            {
                Name = personNameValue.Text,
                Age = int.Parse(ageValue.Text),
            };

            peopleList.Items.Add(newPerson);
        }
    }
}
