﻿using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace FirstConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            #region ლექცია 2


            //IMPLICT CAST - არაცხადი ტიპიზაცია
            //byte y = 10;
            //int x = y;


            //EXPLICIT CAST -ცხადი ტიპიზაცია
            //Arithemmitac overflow - არითმეტიკული გადავსება
            //int x = 256;
            //byte y = checked((byte)x);




            // + - * / %
            // > < >= <= == != // bool
            //++ -- += -= *= /=
            // || ან  && და


            //string x = "A";
            //string y = "B";

            //string z = x + y;

            //int x = 15;
            //int y = 16;

            //x += y;
            //x -= y;
            //x *= y;
            //x /= y;

            //x = x + y;
            //x = x - y;
            //x = x * y;
            //x = x / y;


            //int number = 0;
            //if (number > 0)
            //{
            //    Console.WriteLine("POSITIVE");
            //}
            //else if (number == 0)
            //{
            //    Console.WriteLine("ZERO");
            //}
            //else
            //{
            //    Console.WriteLine("NEGATIVE");
            //}


            //int number = 60;

            //if (number == 2 && number % 2 == 1)
            //{
            //    Console.WriteLine("number is Less then 5");
            //}
            //else if (number == 10)
            //{
            //    Console.WriteLine("number is TEN");
            //}
            //else if (number == 30)
            //{
            //    Console.WriteLine("number is THIRTEE");
            //}
            //else
            //{
            //    Console.WriteLine("TEST");
            //}

            //switch (number)
            //{
            //    case 0:
            //    case 1:
            //    case 2:
            //    case 3:
            //    case 4:
            //        Console.WriteLine("number is Less then 5");
            //        break;
            //    case 10:
            //        Console.WriteLine("number is TEN");
            //        break;
            //    case 30:
            //        Console.WriteLine("number is THIRTEE");
            //        break;
            //    default:
            //        Console.WriteLine("TEST");
            //        break;
            //}


            //Console.Write("Enter the first number: ");
            //int firstNumber = int.Parse(Console.ReadLine());

            //Console.Write("Enter the second number: ");
            //int secondNumber = int.Parse(Console.ReadLine());

            //Console.Write("Enter the third number: ");
            //int thirdNumber = int.Parse(Console.ReadLine());

            //Console.Write("Enter the fourth number: ");
            //int fourthNumber = int.Parse(Console.ReadLine());


            //Console.WriteLine(firstNumber + " " + secondNumber + " " + thirdNumber + " " + fourthNumber);
            //Console.WriteLine($"{firstNumber}{secondNumber}{thirdNumber}{fourthNumber}");
            //Console.WriteLine("{0}{1}{2}{3}",firstNumber,secondNumber,thirdNumber,fourthNumber);

            #endregion


            #region ლექცია 3


            //try
            //{
            //Console.Write("[+ - * /]");
            //char operation = char.Parse(Console.ReadLine());


            //Console.Write("FIRST NUMBER: ");
            //int.TryParse(Console.ReadLine(),out int result);


            //Console.WriteLine(result);

            //Console.Write("SECOND NUMBER: ");
            //int secondNUmber = int.Parse(Console.ReadLine());
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}




            //int i = 0;
            //while (i < 10)
            //{
            //    Console.WriteLine("Nika");
            //    i++;
            //}


            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Nika");
            //}


            //foreach (var item in collection)
            //{
            //}


            //do 
            //{
            //    Console.WriteLine("Nika");
            //} while (true);


            //for(int i = 10; i >= 1; i--)
            //{
            //    Console.WriteLine(i);
            //}


            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        Console.WriteLine($"i: {i}   j: {j}");
            //    }
            //}



            //double max = int.Parse(Console.ReadLine() );
            //double result = default;
            //double avg = default;

            //for (int i = 0; i < max; i++)
            //{
            //    result += i;
            //}

            //avg = result/ max;

            //Console.WriteLine(avg);

            #endregion


            #region ლექცია 4


            //მასივის გამოცხადება
            //string[] students = new string[3];

            //მასივის ინდექსაცია ყოველთვის იწყება 0 - დან
            //მასივზე მნიშვნლეობის მინიჭება 
            //students[0] = valeri;
            //students[1] = tintaini;
            //students[2] = "Tamar";

            //Console.WriteLine(students[0]);
            //Console.WriteLine(students[1]);
            //Console.WriteLine(students[2]);


            //string[] students = { "Valeri", "Tamari", "Tinatini" };

            //for (int i = 0; i < students.Length; i++)
            //{
            //    Console.WriteLine(students[i]);
            //}


            //მომხმარებელს შევავსებინოთ მასივი ხელით.

            //int[] intArray = new int[4];

            //for (int i = 0; i < intArray.Length; i++)
            //{
            //    Console.WriteLine("ENTER THE NUMBER");
            //    intArray[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("---------------------------------------------");

            //foreach (var item in intArray)
            //{
            //    Console.WriteLine(item);
            //}



            //მასივის შევსება შემთხვევითი რიცხვებით
            //Random random = new Random();

            //int[] intArray = new int[4];
            //for (int i = 0; i < intArray.Length; i++)
            //{
            //    intArray[i] = random.Next(-100, -5);
            //}

            //Console.WriteLine("---------------------------------------------");

            //foreach (var item in intArray)
            //{
            //    Console.WriteLine(item);
            //}



            //JAGGEDARRAY
            //int[] stantardArray = new int[3];


            //int[][] jaggedArray = new int[3][];

            //jaggedArray[0] = new int[1] { 151 };
            //jaggedArray[1] = new int[5] { 10, 11, 2, 4, 51 };
            //jaggedArray[2] = new int[2] { 1157, 7 };


            //for (int i = 0; i < jaggedArray.Length; i++)
            //{
            //    for (int j = 0; j < jaggedArray[i].Length; j++)
            //    {
            //        Console.WriteLine(jaggedArray[i][j]);
            //    }
            //}



            //DIMENSIONSARRAY
            //int[,] matrix = new int[2, 3];

            //matrix[0, 0] = 100;
            //matrix[0, 1] = 1200;
            //matrix[0, 2] = 600;

            //matrix[1, 0] = 10000;
            //matrix[1, 1] = 2;
            //matrix[1, 2] = 20;








            #endregion


            #region ლექცია 5


            //int[] collection = { 10, 103, 11, 2, 4, 3 };
            //int sum = 0;

            //for (int i = 0; i < collection.Length; i++)
            //{
            //    if (collection[i] % 2 == 0)
            //    {
            //        sum += collection[i];
            //    }
            //}

            //Console.WriteLine(sum);




            //int[] collection = { 10, 103, 11, 2, 4, 3 };
            //int[] copyCollection = new int[collection.Length];


            //for (int i = 0; i < collection.Length; i++)
            //{
            //    copyCollection[i] = collection[i];
            //}


            //int[] collection = { 1, 1, 12, 4, 3, 3, 2, 7, 7 };

            //for (int i = 0; i < collection.Length; i++)
            //{
            //    bool isUnique = true;

            //    for (int j = 0; j < collection.Length; j++)
            //    {
            //        if (i != j && collection[i] == collection[j])
            //        {
            //            isUnique = false;
            //            break;
            //        }
            //    }

            //    if (isUnique)
            //        Console.WriteLine(collection[i]);
            //}


            //Random random = new Random();
            //int[] collection = new int[5];

            //for (int i = 0; i < collection.Length; i++)
            //{
            //    collection[i] = random.Next(101);
            //}
            //int maxElement = collection[0];

            //for (int i = 0; i < collection.Length; i++)
            //{
            //    if (collection[i] > maxElement)
            //    {
            //        maxElement = collection[i];
            //    }
            //}

            //Console.WriteLine(maxElement);



            //Random random = new Random();
            //int[] collection = new int[5];

            //for (int i = 0; i < collection.Length; i++)
            //{
            //    collection[i] = random.Next(101);
            //}
            //int maxElement = collection[0];
            //int maxIndex = 0;

            //for (int i = 0; i < collection.Length; i++)
            //{
            //    if (collection[i] > maxElement)
            //    {
            //        maxIndex = i;
            //    }
            //}

            //Console.WriteLine(maxIndex);



            //int[] collection = { 10, 7, 2, 4, 1 };

            //for (int i = 0; i < collection.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < collection.Length; j++)
            //    {
            //        if (collection[j] < collection[i])
            //        {
            //            int t = collection[j];
            //            collection[j] = collection[i];
            //            collection[i] = t;
            //        }
            //    }
            //}

            //foreach (var item in collection)
            //{
            //    Console.WriteLine(item);
            //}



            //Compare:
            //CompareOrdinal:
            //Concat:
            //CopyTo:
            //EndsWith:
            //IndexOf:
            //Insert:
            //Join:
            //LastIndexOf:
            //Replace:
            //Substring:
            //ToLower:
            //ToUpper:
            //Trim:

            //Split:


            //CASE CULTURE

            //string text = "Hello!World my name is nika";
            //string text2 = "World";


            //Console.WriteLine(string.Compare(text, 0, text2, 2, text.Length));  // -1 0 1
            //Console.WriteLine(text.CompareTo(text2));
            //Console.WriteLine(string.CompareOrdinal(text, 0, text2, 2, text.Length));  // -1 0 1

            //Console.WriteLine(text + text2);
            //Console.WriteLine($"{text} {text2}");
            //Console.WriteLine("{0} {1}", text, text2);
            //Console.WriteLine(string.Concat(text, " ", text2));

            //StringBuilder builder = new StringBuilder(text);

            //char[] coptCharText = new char[text.Length];
            //text.CopyTo(0, coptCharText, 0, 3);


            //Console.WriteLine(text.EndsWith("O", StringComparison.OrdinalIgnoreCase));
            //Console.WriteLine(text.StartsWith("hel", StringComparison.OrdinalIgnoreCase));
            //Console.WriteLine(text.Contains("x", StringComparison.OrdinalIgnoreCase));

            //Console.WriteLine(text.Contains("EL".ToLower()));
            //Console.WriteLine(text.Contains("EL".ToUpper()));


            //Console.WriteLine(text.IndexOf('h'));
            //Console.WriteLine(text.LastIndexOf('h'));

            //string parsedResult = 12.ToString();

            //Console.WriteLine(text.Insert(1,"Z"));

            //Console.WriteLine(string.Join(',', text, text2));

            //Console.WriteLine(text.Replace("h", "z", StringComparison.OrdinalIgnoreCase));

            //Console.WriteLine(text.Substring(1,3));

            //Console.WriteLine(text.Trim());
            //Console.WriteLine(text.TrimStart());
            //Console.WriteLine(text.TrimEnd());

            //string[] splitedResult = text.Split();


            #endregion


        }
    }
}
