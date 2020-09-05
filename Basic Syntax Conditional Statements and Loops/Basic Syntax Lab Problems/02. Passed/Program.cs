using System;

namespace _02_Passed
{
    class Program
    {
        static void Main(string[] args)
        {
            double gradeInput = double.Parse(Console.ReadLine());

            if (gradeInput >= 3)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
