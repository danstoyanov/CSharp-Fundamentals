using System;

namespace _10_Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int numInput = int.Parse(Console.ReadLine());
            int result = 0;

            for (int repeatNums = 1; repeatNums <= 10; repeatNums++)
            {
                result = numInput * repeatNums;
                Console.WriteLine($"{numInput} X {repeatNums} = {result}");
            }
        }
    }
}
