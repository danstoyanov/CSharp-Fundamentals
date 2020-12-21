using System;

namespace _02_Grades
{
    class Program
    {
        static void Main()
        {
            double gradeInput = double.Parse(Console.ReadLine());
            CheckedGrade(gradeInput);
        }
        static void CheckedGrade(double gradeInput)
        {
            if (gradeInput >= 2.00 && gradeInput <= 2.99)
            {
                Console.WriteLine("Fail");
            }
            else if (gradeInput >= 3.00 && gradeInput <= 3.49)
            {
                Console.WriteLine("Poor");
            }
            else if (gradeInput >= 3.50 && gradeInput <= 4.49)
            {
                Console.WriteLine("Good");
            }
            else if (gradeInput >= 4.50 && gradeInput <= 5.49)
            {
                Console.WriteLine("Very good");
            }
            else if (gradeInput >= 5.50 && gradeInput <= 6.00)
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
