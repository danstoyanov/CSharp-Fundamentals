using System;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;

namespace P03_Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int counts = int.Parse(Console.ReadLine());
            string evenOut = string.Empty;
            string oddOut = string.Empty;

            for (int i = 0; i < counts; i++)
            {
                int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i % 2 == 0)
                {
                    evenOut += array[0] + " ";
                    oddOut += array[1] + " ";
                }
                else
                {
                    evenOut += array[1] + " ";
                    oddOut += array[0] + " ";
                }
            }
            Console.WriteLine(evenOut);
            Console.WriteLine(oddOut);
        }
    }
}
