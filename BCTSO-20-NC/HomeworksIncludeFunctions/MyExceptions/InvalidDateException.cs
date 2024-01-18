namespace Homeworks.MyExceptions
{
    public class InvalidDateException : Exception
    {
        public InvalidDateException() : base("Invalid date format")
        {
        }
    }
}
