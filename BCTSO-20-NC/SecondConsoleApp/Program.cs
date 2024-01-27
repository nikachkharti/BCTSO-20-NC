using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Security.AccessControl;

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







        }

    }
}
