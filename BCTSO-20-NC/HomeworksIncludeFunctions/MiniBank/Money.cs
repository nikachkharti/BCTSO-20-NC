using Homeworks.MyExceptions;

namespace Homeworks.MiniBank
{
    public class Money
    {
        private string currency;
        public string Currency
        {
            get { return currency; }
            set
            {
                if (value.Length == 3)
                {
                    currency = value;
                }
                else
                {
                    throw new IncorrectMoneyException();
                }
            }
        }

        private double amount;
        public double Amount
        {
            get { return amount; }
            set
            {
                if (value > 0)
                {
                    amount = value;
                }
                else
                {
                    throw new IncorrectMoneyException();
                }
            }
        }


        public Money(string currency, double amount)
        {
            Currency = currency;
            Amount = amount;
        }

        public Money(double amount)
        {
            Amount = amount;
        }

        public static Money operator +(Money a, Money b)
        {
            if (a.Currency != b.Currency)
                throw new IncorrectMoneyException();

            return new Money(amount: a.Amount + b.Amount);
        }

        public static Money operator -(Money a, Money b)
        {
            if (a.Currency != b.Currency)
                throw new IncorrectMoneyException();

            return new Money(amount: a.Amount - b.Amount);
        }

        public static Money operator *(Money a, Money b)
        {
            if (a.Currency != b.Currency)
                throw new IncorrectMoneyException();

            return new Money(amount: a.Amount * b.Amount);
        }

        public static Money operator /(Money a, Money b)
        {
            if (a.Currency != b.Currency)
                throw new IncorrectMoneyException();

            return new Money(amount: a.Amount / b.Amount);
        }

        public static bool operator ==(Money a, Money b)
        {
            if (a.Currency != b.Currency)
                throw new IncorrectMoneyException();

            return a.Amount == b.Amount;
        }

        public static bool operator !=(Money a, Money b)
        {
            if (a.Currency != b.Currency)
                throw new IncorrectMoneyException();

            return a.Amount != b.Amount;
        }

        public static bool operator >(Money a, Money b)
        {
            if (a.Currency != b.Currency)
                throw new IncorrectMoneyException();

            return a.Amount > b.Amount;
        }

        public static bool operator <(Money a, Money b)
        {
            if (a.Currency != b.Currency)
                throw new IncorrectMoneyException();

            return a.Amount < b.Amount;
        }

        public static bool operator >=(Money a, Money b)
        {
            if (a.Currency != b.Currency)
                throw new IncorrectMoneyException();

            return a.Amount >= b.Amount;
        }

        public static bool operator <=(Money a, Money b)
        {
            if (a.Currency != b.Currency)
                throw new IncorrectMoneyException();

            return a.Amount <= b.Amount;
        }

        public override string ToString()
        {
            return $"{Amount} {Currency}";
        }

    }
}
