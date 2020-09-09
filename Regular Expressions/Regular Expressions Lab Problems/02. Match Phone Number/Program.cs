using System;
using System.Text.RegularExpressions;

namespace _02_Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            // регекса започва с + 359
            // слет тово числата ще бъдат само от 2-ки 
            // разделени на три групи една 2-ка, три 2-ки и четере 2-ки !
            // сплитнати ще бъдат с интервал    " "    и с   '-' !!!!
            // 
            // 
            // 
            // 

            string phoneNumber = Console.ReadLine();

            var regex = new Regex();

            var matches = regex.Match(phoneNumber);

            foreach (Match match in matches)
            {
                Console.WriteLine();
            }
        }
    }
}
