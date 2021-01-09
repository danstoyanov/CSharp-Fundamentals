using System;
using System.Linq;
using System.Runtime.ExceptionServices;

namespace _05_Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int currentValue = nums[i];

                if (currentValue % 2 == 0)
                {
                    sum += currentValue;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
