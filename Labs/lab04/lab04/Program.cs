namespace lab04
{
    struct Date
    {
        int year;
        int month;
        int day;

        #region Validate on data with setter & getter
        public void set_year(int _year)
        {
            if (_year >= 1789 && _year <= 2022)
                year = _year;
            else {
                Console.WriteLine("Invalid year");
            }
        }
        public void set_month(int _month)
        {
            if (_month > 0 && _month <= 12)
                month = _month;
            else if (_month > 12)
            {
                year += _month / 12;
                month = _month % 12;
            }
        }
        public void set_day(int _day)
        {
            if (month % 2 == 0)
            {
                if (_day > 0 && _day <= 31)
                {
                    day = _day;
                }
                else
                {
                    month += _day / 31;
                    day = _day % 31;
                }
            }
            else
            {
                if (_day > 0 && _day <= 30)
                {
                    day = _day;
                }
                else
                {
                    month += _day / 30;
                    day = _day % 30;
                }
            }

        }

        public int get_year()
        {
            return year;
        }
        public int get_month()
        { return month; }

        public int get_day()
        { return day; }
        #endregion


        public void print()
        {
            Console.WriteLine($"Date = {day}/{month}/{year}");
        }


        #region Validate on data with prop 

        public int Year
        {
            set
            {
                if (value >= 1789 && value <= 2022)
                    year = value;
                else
                {
                    Console.WriteLine("Invalid year");
                }
            }
            get {
                return year; 
            }
        }
        public int Month
        { 
            set
            {
                if (value > 0 && value <= 12)
                    month = value;
                else if (value > 12)
                {
                    year += value / 12;
                    month = value % 12;
                }
            }
            get { 
                return month; 
            }
        }
        public int Day
        {
            set
            {
                if (month % 2 == 0)
                {
                    if (value > 0 && value <= 31)
                    {
                        day = value;
                    }
                    else
                    {
                        month += value / 31;
                        day = value % 31;
                    }
                }
            }
            get { 
                return day; 
            }
        }

        #endregion
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Date date = new Date();
            #region with setter & getter 
            Console.WriteLine("Enter the year");
            date.set_year(int.Parse(Console.ReadLine()));

            Console.WriteLine("Enter the mounth");
            date.set_month(int.Parse(Console.ReadLine()));

            Console.WriteLine("Enter the day");
            date.set_day(int.Parse(Console.ReadLine()));
            date.print();
            #endregion

            #region with prop
            Console.WriteLine("Enter the year");
            date.Year = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the mounth");
            date.Month = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the day");
            date.Day = int.Parse(Console.ReadLine());
            date.print();
            #endregion

            #region array of date
            Console.WriteLine("Enter number of dates");
            int numberOfDate = int.Parse(Console.ReadLine());
            Date[] arrDate = new Date[numberOfDate];

            for (int i = 0; i < arrDate.Length; i++)
            {
                Console.WriteLine($"Enter year date {i + 1}");
                arrDate[i].Year = int.Parse(Console.ReadLine());

                Console.WriteLine($"Enter mounth date {i + 1}");
                arrDate[i].Month = int.Parse(Console.ReadLine());

                Console.WriteLine($"Enter day date {i + 1}");
                arrDate[i].Day = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arrDate.Length; i++)
            {

                arrDate[i].print();
            }

            #endregion


        }
    }
}