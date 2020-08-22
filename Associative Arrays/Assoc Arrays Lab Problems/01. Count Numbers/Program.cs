using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            var dict = new SortedDictionary<double, int>();

            foreach (var num in numbers)
            {
                if (dict.ContainsKey(num))
                {
                    dict[num]++;
                }
                else
                {
                    dict.Add(num, 1);
                }
            }

            foreach (var num in dict)
            {
                Console.WriteLine($"{num.Key} -> {num.Value}");
            }
        }
    }
}
