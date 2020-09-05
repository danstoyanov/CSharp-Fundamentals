using System;

namespace _01_Student_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameInput = Console.ReadLine();
            int ageInput = int.Parse(Console.ReadLine());
            double gradeInput = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {nameInput}, Age: {ageInput}, Grade: {gradeInput:F2}");
        }
    }
}
