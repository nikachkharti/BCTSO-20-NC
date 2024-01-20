using Homeworks.MyExceptions;
using System.Runtime.CompilerServices;

namespace Homeworks.MiniBank
{
    public class Account
    {
        private string accountNumber;
        public string AccountNumber
        {
            get { return accountNumber; }
            set
            {
                if (value.Length == 22)
                {
                    accountNumber = value;
                }
            }
        }

        public Money Money { get; set; }

        public void Fill(double balance)
        {
            Money.Amount += balance;
        }

        public void Withdraw(double balance)
        {
            if (Money.Amount >= balance)
            {
                Money.Amount -= balance;
            }
            else
            {
                throw new InsufficientFundsException();
            }
        }

        public void Transfer(Client client, double transferAmount)
        {
            if (Money.Amount >= transferAmount)
            {
                Money.Amount -= transferAmount;
                client.Account.Money.Amount += transferAmount;
            }
            else
            {
                throw new InsufficientFundsException();
            }
        }
    }
}
