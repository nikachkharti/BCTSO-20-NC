using System.Runtime.Serialization;

namespace Homeworks.MyExceptions
{
    public class InsufficientFundsException : Exception
    {
        public InsufficientFundsException() : base("Insufficient funds")
        {
        }
    }
}
