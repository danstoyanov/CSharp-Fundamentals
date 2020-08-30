using System;

namespace _09_Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // In this problem we have to find the odd numbers in the current fod loop.
            // This is mathematic excercise and in will be good to repeat this problem !!!! 

            int numberInput = int.Parse(Console.ReadLine());
            int sumOfNumbers = 0;

            for (int numCount = 1; numCount < numberInput * 2; numCount += 2)
            {
                sumOfNumbers += numCount;
                Console.WriteLine(numCount);

            }

            Console.WriteLine($"Sum: {sumOfNumbers}");
        }
    }
} 
