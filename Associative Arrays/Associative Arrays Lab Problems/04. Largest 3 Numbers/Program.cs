using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Largest_3_Numbers
{
    class Program
    {
        static void Main()
        {
            var integers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            integers.Sort();
            integers.Reverse();

            if (integers.Count >= 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(integers[i] + " ");
                }

                return;
            }
            else
            {
                Console.Write(string.Join (" ", integers));
            }
        }
    }
}
