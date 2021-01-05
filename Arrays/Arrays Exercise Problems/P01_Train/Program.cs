using System;
using System.Collections.Generic;

namespace P01_Train
{
    class Program
    {
        static void Main()
        {
            int counter = int.Parse(Console.ReadLine());
            List<int> nums = new List<int>();
            int sum = 0;

            for (int i = 0; i < counter; i++)
            {
                int numberInput = int.Parse(Console.ReadLine());
                nums.Add(numberInput);

                sum += numberInput;
            }

            Console.WriteLine(string.Join(" ", nums));
            Console.WriteLine(sum);
        }
    }
}
