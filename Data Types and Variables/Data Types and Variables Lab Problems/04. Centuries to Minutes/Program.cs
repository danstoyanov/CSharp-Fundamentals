using System;

namespace _04_Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {   // To complete the problem you must to know: 
            // 1 centuries = 100 years = 36524 days = 876576 hours = 52594560 minutes !!!
            int centuryInpit = int.Parse(Console.ReadLine());

            int yearsCalculate = centuryInpit * 100;
            // to calculate integer with double -- input (int) and then (yearsCalculater * "double/decimal number") !
            int daysCalculate = (int)(yearsCalculate * 365.2422); 
            int hoursCalculate = daysCalculate * 24;
            int minutesCalculate = hoursCalculate * 60;

            Console.WriteLine($"{centuryInpit} centuries = {yearsCalculate} years = {daysCalculate} days = " +
                $"{hoursCalculate} hours = {minutesCalculate} minutes");
        }
    }
}
