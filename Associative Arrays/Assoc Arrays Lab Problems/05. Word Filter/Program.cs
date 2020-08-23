using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace _05_Word_Filter
{
    class Program
    {
        static void Main()
        {
            var list = Console.ReadLine()
                .Split()
                .Where(w => w.Length % 2 == 0)
                .ToList();

            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
        }
    }
}
