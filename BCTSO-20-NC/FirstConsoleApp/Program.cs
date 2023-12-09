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


        }
    }
}
