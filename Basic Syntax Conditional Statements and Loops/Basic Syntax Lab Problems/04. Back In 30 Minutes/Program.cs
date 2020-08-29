using System;

namespace _04_Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        { 
            // The problem has been solved in Judge with 100/100, but you must 
            // try to repeat this exercise again !!
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            // 1 - Make hours to minutes !
            // 2 - calculate totalTime !

            int hoursPerMinuter = hours * 60;
            int totalTime = (hoursPerMinuter + minutes) + 30;

            // at the End - you must calculate the "hours", like --->> 21 or 09 ...
            // at the End - you must calculate the "minutes", like --->> 59 or 00 ...

            double hoursToPrint = (totalTime / 60); // hours
            double minutesToPrint = totalTime * 1.0 % 60; // minutes

            if (hoursToPrint > 23)
            {
                if (minutesToPrint <= 9)
                {
                    Console.WriteLine($"{0}:0{minutesToPrint}");
                }
                else
                {
                    Console.WriteLine($"{0}:{minutesToPrint}");
                }
            }
            else
            {
                if (minutesToPrint <= 9)
                {
                    Console.WriteLine($"{hoursToPrint}:0{minutesToPrint}");
                }
                else
                {
                    Console.WriteLine($"{hoursToPrint}:{minutesToPrint}");
                }
            }
        }
    }
}

