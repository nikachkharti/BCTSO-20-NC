namespace FirstConsoleApp
{
    //კლასის გამოცხადება კლასი ცხადდება იმისთვის რომ აღიწეროს როგორი იქნება ობიექტი
    public class Person
    {
        //AUTO PROPERTY
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //FULL PROPERTY
        private int age;
        public int Age
        {
            get { return this.age; }
            set
            {
                if (value > 0)
                {
                    this.age = value;
                }
            }
        }

        //ფუნქცია
        //public Person(string firstName, string lastName, int age)
        //{
        //    this.firstName = firstName;
        //    this.lastName = lastName;
        //    if (age > 0)
        //    {
        //        this.age = age;
        //    }
        //}


        //მეთოდი
        //public void IntroduceYourself()
        //{
        //    Console.WriteLine($"{firstName} {lastName} {age}");
        //}


        protected virtual void Test()
        {
            Console.WriteLine("HELLO WORLD");
        }
    }
}
