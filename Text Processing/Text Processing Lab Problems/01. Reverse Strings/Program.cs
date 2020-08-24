using System;

namespace _01_Reverse_Strings
{
    class Program
    {
        static void Main()
        {
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string reverse = input;
                string line = string.Empty;

                for (int i = reverse.Length - 1; i >= 0; i--)
                {
                    line += reverse[i];
                }

                Console.WriteLine(reverse + " = " + line);
            }
        }
    }
}
