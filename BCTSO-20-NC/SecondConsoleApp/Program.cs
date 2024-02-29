using Homeworks;
using SecondConsoleApp.Events;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Threading.Tasks.Dataflow;
using static System.Formats.Asn1.AsnWriter;

namespace SecondConsoleApp
{


    internal class Program
    {
        static void Main(string[] args)
        {
            #region ოპერატორების გადატვირთვა 10

            //class Person
            //    {
            //        public int Age { get; set; }
            //        public string Name { get; set; }

            //        public static Person operator +(Person a, Person b)
            //        {
            //            Person result = new Person() { Age = a.Age + b.Age, Name = a.Name + b.Name };
            //            return result;
            //        }

            //        public static Person operator -(Person a, Person b)
            //        {
            //            Person result = new Person() { Age = a.Age - b.Age, Name = a.Name + b.Name };
            //            return result;
            //        }

            //        public static Person operator *(Person a, Person b)
            //        {
            //            Person result = new Person() { Age = a.Age * b.Age, Name = a.Name + b.Name };
            //            return result;
            //        }

            //        public static Person operator /(Person a, Person b)
            //        {
            //            Person result = new Person() { Age = a.Age / b.Age, Name = a.Name + b.Name };
            //            return result;
            //        }

            //        public static bool operator >(Person a, Person b)
            //        {
            //            return a.Age > b.Age;
            //        }

            //        public static bool operator >=(Person a, Person b)
            //        {
            //            return a.Age >= b.Age;
            //        }

            //        public static bool operator <(Person a, Person b)
            //        {
            //            return a.Age < b.Age;
            //        }

            //        public static bool operator <=(Person a, Person b)
            //        {
            //            return a.Age <= b.Age;
            //        }

            //        public static bool operator ==(Person a, Person b)
            //        {
            //            return a.Age == b.Age;
            //        }

            //        public static bool operator !=(Person a, Person b)
            //        {
            //            return a.Age != b.Age;
            //        }
            //    }



            //Person p1 = new Person();
            //p1.Age = 10;
            //p1.Name = "Giorgi";

            //Person p2 = new Person();
            //p2.Age = 20;
            //p2.Name = "Daviti";

            //var result = p1 + p2;



            //try
            //{
            //    //var x = 12;
            //    //Console.WriteLine(x / 0);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("FINALLY");
            //}


            #endregion

            #region ლექცია 11 List 

            //int[] ar = { 100, 200, 500 };


            //List<int> intList = new List<int>();
            //intList.Add(12);
            //intList.Add(132);
            //intList.Add(15);
            //intList.Add(21);
            //intList.Add(3);
            //intList.Add(12);

            //intList.InsertRange(2, ar);
            #endregion


            #region ლექცია 12 მონაცემთა სტრუქტურები

            //List<string> names = new()
            //{
            //    "Nika",
            //    "Nika",
            //    "Giorgi",
            //    "Giorgi",
            //    "Daviti",
            //    "Daviti",
            //    "Mariami",
            //    "Tamazi"
            //};


            //LINKEDLIST
            //LinkedList<string> people = new LinkedList<string>(names);


            //QUEUE
            //Queue<string> people = new Queue<string>(names);
            //people.Enqueue("Jemali");

            //people.Dequeue();


            //STACK
            //Stack<string> stack = new(names);
            //stack.Push("Jemali");
            //stack.Pop();


            //HASHSET
            //HashSet<string> people = new(names);
            //HashSet<string> people2 = new(names2);

            //people.IntersectWith(people2);



            //DICTIONARY
            //Dictionary<string, string> countriesWithCuurency = new()
            //{
            //    {"Georgia","GEL" },
            //    {"USA","USD" },
            //    {"Japan","JYP" }
            //};



            //int[] intAr = { 8, 8, 8 };
            //var res = CustomAlgorithms.Sum(intAr);



            #endregion


            #region ლექცია 13 Generic
            //int[] intAr = { 100, 5, 4, 12, 522 };
            //string[] texts = { "asdasd", "asdasd", "q2asd", "fafs" };

            //var result = CustomAlgorithms.Sort(intAr);
            #endregion



            #region 14 Delegate ანონომური ფუნქციები

            //დელეგატი არის ტიპი რომელსაც შეუძლია ფუნქციის მინიჭება 

            //FUNC --- ინიჭებს ისეთ ფუნქციას რომლის დასაბრუნებელ მნიშვნელობასაც ირჩევთ თავად
            //ACTION --- ინიჭებს ისეთ ფუნქციას რომელიც არის void ტიპის

            //PREDICATE --- ინიჭებს ისეთ ფუნქციას რომელიც აბრუნებს bool მნიშვნელობას






            #endregion


            #region 15 Extension methods Value ref
            //List<int> intList = new() { 22, 22, 22, 71, 4, 3, 2 };
            //var result = intList
            //    .CustomDistinct();

            //var allOdds = CustomAlgorithms.FindAll(intList, x => x % 2 != 0);
            //var allOdsMulitple3 = CustomAlgorithms.Select(allOdds, x => x *= 3);



            //IEnumerable<int> result = intList
            //    .Where(x => x % 2 != 0)
            //    .Select(x => x *= 3);


            //var res = CustomAlgorithms.OrderBy(intList, (x, y) => x % 2 == 0);

            #endregion


            #region 16 LINQ Events

            //Extension method      //LINQ Query


            //var data = File.ReadAllLines(@"C:\Users\User\Desktop\IT STEP\BCTSO-20-NC\BCTSO-20-NC\HomeworksIncludeFunctions\vehicles.csv");

            //var result = data
            //    .Skip(1)
            //    .Select(Vehicle.Parse)
            //    .OrderByDescending(x => x.Combined)
            //    .Take(10);



            //var result = (from item in data.Skip(1)
            //              let vehicles = Vehicle.Parse(item)
            //              orderby vehicles.Combined descending
            //              select vehicles).Take(10);




            //IEnumerable<IGrouping<string, Vehicle>> groups = data
            //    .Skip(1)
            //    .Select(Vehicle.Parse)
            //    .OrderByDescending(x => x.Combined)
            //    .GroupBy(x => x.Make);



            //IEnumerable<IGrouping<string, Vehicle>> groups = from item in data.Skip(1)
            //                                                 let vehicles = Vehicle.Parse(item)
            //                                                 orderby vehicles.Combined descending
            //                                                 group vehicles by vehicles.Make into groupedCars
            //                                                 orderby groupedCars.Count() descending
            //                                                 select groupedCars;



            //foreach (var group in groups)
            //{
            //    Console.WriteLine($"{group.Key} --- {group.Count()}");

            //    foreach (var vehicle in group)
            //        Console.WriteLine($"{vehicle.Make} {vehicle.Model}");

            //    Console.WriteLine("-------------------------------");
            //}


            //Sensor sensor = new();
            //sensor.TemperatureLimitReached += Sensor_TemperatureFuncttion;


            //for (int i = 0; i < 10; i++)
            //{
            //    sensor.SimulateTemperatureChange();
            //}

            //private static void Sensor_TemperatureFuncttion(object sender, TemperatureEventArgs args)
            //{
            //    throw new Exception("GVISHVELET");
            //}
            #endregion



            #region 17 Attributes Reflection


            //CIL --- Common Intemadiate Language
            //  |
            //  |
            //  |  IL Code Assembley დავაბრუნო უკან
            //  |
            //  |
            //CLR --- Common Language Runtime (JIT - Just In Time)
            //  |
            //  |
            //  |
            //  |
            //  |
            //Assembler
            //  |
            //  |
            //  |
            //  |
            //Native Code (01011101)



            //Student s1 = new();
            //Type studentDataType = s1.GetType();

            //MethodInfo[] result = studentDataType.GetMethods();
            //PropertyInfo[] result = studentDataType.GetProperties();
            //ConstructorInfo[] result = studentDataType.GetConstructors();
            //var result = studentDataType.GetInterfaces();


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}



            //Student newStudent = new()
            //{
            //    FirsName = "Nika",
            //    StartClasses = DateTime.Now.AddDays(1),
            //    EndClasses = DateTime.Now
            //};

            //List<ValidationResult> validationResults = new();
            //ValidationContext validationContext = new(newStudent);

            //if (!Validator.TryValidateObject(newStudent, validationContext, validationResults, true))
            //{
            //    foreach (var validationResult in validationResults)
            //    {
            //        Console.WriteLine(validationResult.ErrorMessage);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("OK");
            //}



            //DtoGenerator.GenerateDto(typeof(Student), "C:\\Users\\User\\Desktop\\IT STEP\\BCTSO-20-NC\\BCTSO-20-NC\\SecondConsoleApp\\Dtos\\");


            #endregion




            #region ობიექტზე ორიენტირებული პროგრამირება OOP

            #region მემკვიდრეობა --- Inheritence
            //class Person
            //    {
            //        public string FirsName { get; set; }
            //        public string LastName { get; set; }
            //        public int Age { get; set; }
            //    }

            //    class Student : Person
            //    {
            //        public double Score { get; set; }
            //    }


            #endregion

            #region აბსტრაქცია -- Abstraction

            //interface IPerson
            //    {
            //        void Walk();
            //    }

            //    abstract class Person
            //    {
            //        public string FirsName { get; set; }
            //        public string LastName { get; set; }
            //        public int Age { get; set; }

            //        public abstract void Talk();
            //    }

            //    class Student : Person, IPerson
            //    {
            //        public double Score { get; set; }

            //        public override void Talk()
            //        {
            //            Console.WriteLine($"My name is {FirsName} {LastName} age is {Age} Score is {Score}");
            //        }

            //        public void Walk()
            //        {
            //            Console.WriteLine("WALKING");
            //        }
            //    }


            #endregion


            #region პოლიმორფიზმი -- Polymorphyism

            //class Person
            //    {
            //        public string FirsName { get; set; }
            //        public string LastName { get; set; }
            //        public int Age { get; set; }

            //        public virtual void Talk()
            //        {
            //            Console.WriteLine($"My name is {FirsName} {LastName} age is {Age}");
            //        }
            //    }

            //    class Student : Person
            //    {
            //        public double Score { get; set; }

            //        public override void Talk()
            //        {
            //            Console.WriteLine($"My name is {FirsName} {LastName} age is {Age} score is {Score}");
            //        }
            //    }

            //    class Teacher : Person
            //    {
            //        public string Subject { get; set; }

            //        public override void Talk()
            //        {
            //            Console.WriteLine($"My name is {FirsName} {LastName} age is {Age} subject is {Subject}");
            //        }
            //    }


            //ILAPARAKE_BICHO(new Teacher() { FirsName = "Levani", LastName = "Giorgadze", Age = 22, Subject = "C#" });

            //static void ILAPARAKE_BICHO(Person person)
            //{
            //    person.Talk();
            //}

            #endregion


            #region ენკაფსულაცია -- Encapsulation


            //class Person
            //    {
            //        public int Age { get; }

            //        public Person(DateTime birthDate)
            //        {
            //            Age = DateTime.Now.Year - birthDate.Year;
            //        }
            //    }


            #endregion




            #endregion


            //DRY --- Dont Repeat Yourself

            #region KISS --- Keep It Simple Stupid

            //int age = 10;

            #endregion


            #region SOLID
            //1.Single Responsibility Principle --- 

            #region ნებისმიერი კოდი აუცილებლად უნდა ასრულებდეს ერთ საქმეს

            //static int Sum(int x, int y)
            //{
            //    int result = x + y;
            //    return result;
            //}

            #endregion


            //2.Open Closed Principle ---


            #region კოდი ღია უნდა იყოს განვრცობისთვის, მაგრად დახურული უნდა იყოს მოდიფიკაციისთვის.

            //CustomAlgorithms Project იხილეთ

            #endregion

            //3.Liskov Subtitional Priniciple --- 

            #region მშობელი ობიექტები უნდა იყვნენც ჩანაცვლებადი შვილი კლასების მიერ ისე რომ ამან არაფერი უკუშედეგი არ გამოიწვიოს.



            #endregion

            //4.Interface Segeragion Principle ---


            #region კლასი არ უნდა ვაიძულოთ რომ მოახდინოს იმ ინტერფეისის იმპლემენტაცია რომელიც არ სჭირდება
            //interface ISleeper
            //    {
            //        void Sleep();

            //    }

            //    interface IEater
            //    {
            //        void Eat();
            //    }

            //    interface IWorker
            //    {
            //        void Work();
            //    }

            //    class Worker : IWorker, IEater, ISleeper
            //    {
            //        public void Eat()
            //        {
            //            throw new NotImplementedException();
            //        }

            //        public void Sleep()
            //        {
            //            throw new NotImplementedException();
            //        }

            //        public void Work()
            //        {
            //            throw new NotImplementedException();
            //        }
            //    }
            #endregion


            //5.Dependency Inversion Principle --- 

            #region მაღალი დონის ტიპები (მშობლები) არ უნდა იყვნენ დამოკიდებული დაბალი ლეველის ტიპებზე (წარმოებულ ტიპებზე), ორივენი დამოკიდებული უნდა იყვნენ ზოგად ტიპებზე

            //Generic Repository
            //იხილეთ ბანკის აპლიკაცია

            #endregion



            #endregion


        }





    }
}
