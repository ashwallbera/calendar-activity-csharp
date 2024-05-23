

namespace CalendarActivity
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.Write("Please Enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            int month = 1; 
            int day = 1;

            new Program().displayMonth(new DateTime(year, month, day));

        }

        private void displayMonth(DateTime dateTime)
        {
           
            // Traverse Day
            foreach (DateTime day in EachDay(dateTime, new DateTime(dateTime.Year, 12, 31)))
            {
                // Number of days in a month
                int days = DateTime.DaysInMonth(day.Year, day.Month);
                displayDay(day);
                if(day.Day == days)
                {
                    Console.WriteLine("\n");
                }
            }
                
            Console.WriteLine();
        }

        private void displayDay(DateTime dateTime)
        {
           
            if(dateTime.Day== 1)
            {
                this.displayHeader(dateTime);
            }
            // Check start
            if(dateTime.DayOfWeek == DayOfWeek.Sunday && dateTime.Day == 1)
            {
                Console.Write("");
            }
            else if (dateTime.DayOfWeek == DayOfWeek.Monday && dateTime.Day == 1)
            {
                Console.Write("   ");
            }
            else if (dateTime.DayOfWeek == DayOfWeek.Tuesday && dateTime.Day == 1)
            {
                Console.Write("      ");
            }
            else if (dateTime.DayOfWeek == DayOfWeek.Wednesday && dateTime.Day == 1)
            {
                Console.Write("         ");
            }
            else if (dateTime.DayOfWeek == DayOfWeek.Thursday && dateTime.Day == 1)
            {
                Console.Write("            ");
            }
            else if (dateTime.DayOfWeek == DayOfWeek.Friday && dateTime.Day == 1)
            {
                Console.Write("               ");
            }
            else if (dateTime.DayOfWeek == DayOfWeek.Saturday && dateTime.Day == 1)
            {
                Console.Write("                  ");
            }
            for (int i = 0; i < 7; i++)
            {
                // Sunday
                if(dateTime.DayOfWeek == DayOfWeek.Sunday && i == 0)
                {
                    Console.Write($"{this.spaceDisplayed(dateTime.Day)}");
                }
                else if (dateTime.DayOfWeek == DayOfWeek.Monday && i == 1)
                {
                    Console.Write($"{this.spaceDisplayed(dateTime.Day)}");
                }
                else if (dateTime.DayOfWeek == DayOfWeek.Tuesday && i == 2)
                {
                    Console.Write($"{this.spaceDisplayed(dateTime.Day)}");
                }
                else if (dateTime.DayOfWeek == DayOfWeek.Wednesday && i == 3)
                {
                    Console.Write($"{this.spaceDisplayed(dateTime.Day)}");
                }
                else if (dateTime.DayOfWeek == DayOfWeek.Thursday && i == 4)
                {
                    Console.Write($"{this.spaceDisplayed(dateTime.Day)}");
                }
                else if (dateTime.DayOfWeek == DayOfWeek.Friday && i == 5)
                {
                    Console.Write($"{this.spaceDisplayed(dateTime.Day)}");
                }
                else if(dateTime.DayOfWeek == DayOfWeek.Saturday && i == 6)
                {
                    Console.Write($"{this.spaceDisplayed(dateTime.Day)}\n");
                }
            }
        }

        /* Credits to Stack overflow
         * https://stackoverflow.com/questions/1847580/how-do-i-loop-through-a-date-range
         */
        public IEnumerable<DateTime> EachDay(DateTime from, DateTime thru)
        {
            for (var day = from.Date; day.Date <= thru.Date; day = day.AddDays(1))
                yield return day;
        }


        private string spaceDisplayed(int day)
        {
            if (day > 0 && day < 10)
            {
                return $"{day}  ";
            }
            else
                return $"{day} ";
        }

        private void displayHeader(DateTime dateTime)
        {
            Console.WriteLine(dateTime.ToString("MMMM"));
            List<string> displayDayOfWeek = new List<string>()
            {
                "Su",
                "Mo",
                "Tu",
                "We",
                "Th",
                "Fr",
                "Sa"
            };

            // Header 
            foreach (string day in displayDayOfWeek)
            {
                Console.Write($"{day} ");
            }
            Console.WriteLine();
        }
    }
}