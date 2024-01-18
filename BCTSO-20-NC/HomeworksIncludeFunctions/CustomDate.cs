using Homeworks.MyExceptions;

namespace Homeworks
{
    public class CustomDate
    {
        private int day;

        public int Day
        {
            get { return day; }
            set 
            {
                if (value <= 31)
                {
                    day = value; 
                }
                else
                {
                    throw new InvalidDateException();
                }
            }
        }


        private int month;
        public int Month
        {
            get { return month; }
            set 
            {
                if (value <= 12)
                {
                    month = value; 
                }
                else
                {
                    throw new InvalidDateException();
                }
            }
        }

        public int Year { get; set; }

        public CustomDate()
        {
        }

        public CustomDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public void AddDays(int days)
        {
            if (Day <= 31 && Day >= 1)
            {
                Day += days;
            }
            else
                throw new InvalidDateException();
        }

        public void AddMonths(int months)
        {
            if (Month <= 12 && Month >= 1)
            {
                Month += months;
            }
            else
                throw new InvalidDateException();
        }

        public void AddYears(int years)
        {
            Year += years;
        }

        public static CustomDate operator -(CustomDate a, CustomDate b)
        {
            return new CustomDate(a.Day - b.Day, a.Month - b.Month, a.Year - b.Year);
        }

        public override string ToString() => $"{Year}-{Month}-{Day}";

    }
}
