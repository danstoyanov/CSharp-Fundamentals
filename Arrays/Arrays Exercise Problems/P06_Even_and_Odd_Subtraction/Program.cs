using System;
using System.Linq;

namespace _06_Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int evenResult = 0;
            int oddResult = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int currentNumber = nums[i];

                if (currentNumber % 2 == 0)
                {
                    evenResult += currentNumber;     
                }
                else
                {
                    oddResult += currentNumber;                 
                }
            }

            Console.WriteLine(evenResult - oddResult);

        }
    }
}
