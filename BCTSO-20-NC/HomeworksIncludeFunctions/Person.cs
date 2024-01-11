namespace Homeworks
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                {
                    age = value;
                }
            }
        }

        private string pin;
        public string Pin
        {
            get { return pin; }
            set
            {
                if (value.Length == 11)
                {
                    pin = value;
                }
            }
        }

        private string phoneNumber;
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                if (value.Length == 9)
                {
                    phoneNumber = value;
                }
            }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                if (value.Contains('@') && value.Contains('.'))
                {
                    email = value;
                }
            }
        }


        //public Person(string firstName, string lastName, int age, string pin, string phoneNumber, string email)
        //{
        //    FirstName = firstName;
        //    LastName = lastName;
        //    Age = age;
        //    Pin = pin;
        //    PhoneNumber = phoneNumber;
        //    Email = email;
        //}

        public override string ToString()
        {
            return $"{FirstName} {LastName} {Age}";
        }

        //public void DisplayInfo()
        //{
        //    Console.WriteLine($"{FirstName} {LastName} {Age}");
        //}
    }
}
