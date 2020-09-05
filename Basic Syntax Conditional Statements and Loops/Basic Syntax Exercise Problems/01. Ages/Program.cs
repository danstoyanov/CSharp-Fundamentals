using System;

namespace _01_Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int ageInput = int.Parse(Console.ReadLine());
            string personOutput = "";

            if (ageInput >= 0 && ageInput <= 2)
            {
                personOutput = "baby";
            }
            else if (ageInput >= 3 && ageInput <= 13)
            {
                personOutput = "child";
            }
            else if (ageInput >= 14 && ageInput <= 19)
            {
                personOutput = "teenager";
            }
            else if (ageInput >= 20 && ageInput <= 65)
            {
                personOutput = "adult";
            }
            else if (ageInput >= 66)
            {
                personOutput = "elder";
            }

            Console.WriteLine(personOutput);
        }
    }
}
