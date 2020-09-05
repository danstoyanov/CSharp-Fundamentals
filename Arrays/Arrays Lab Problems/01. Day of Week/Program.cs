using System;

namespace _01_Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = new string[7]{ "Monday", "Tuesday", "Wednesday",
            "Thursday", "Friday", "Saturday", "Sunday" };

            int dayNumInput = int.Parse(Console.ReadLine());

            if (dayNumInput > 0 && dayNumInput <= 7)
            {
                Console.WriteLine(days[dayNumInput - 1]);
            }
            else if (dayNumInput <= 0 || dayNumInput >= 8)
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
