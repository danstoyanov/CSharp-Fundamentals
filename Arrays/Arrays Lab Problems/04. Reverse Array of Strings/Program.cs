using System;
using System.Globalization;
using System.Linq;

namespace _04_Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayInputs = Console.ReadLine().Split().ToArray();

            for (int i = 0; i < arrayInputs.Length / 2; i++)
            {
                string temp = arrayInputs[i]; // We saved string[0] == "a" !!!!
                arrayInputs[i] = arrayInputs[arrayInputs.Length - i - 1];
                arrayInputs[arrayInputs.Length - i - 1] = temp;

            }
            Console.Write(string.Join(" ", arrayInputs));
        }
    }
}
