using System;
using System.Text.RegularExpressions;

namespace _01_Match_Full_Name
{
    class Program
    {
        static void Main()
        {
            string names = Console.ReadLine();

            var regex = new Regex(@"\b[A-Z][a-z]+ \b[A-Z][a-z]+");

            MatchCollection currNames = regex.Matches(names);

            foreach (Match name in currNames)
            {
                Console.WriteLine($"{name.Value} ");
            }

            Console.WriteLine();
        }
    }
}
