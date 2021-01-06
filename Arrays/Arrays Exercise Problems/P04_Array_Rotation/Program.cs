using Microsoft.VisualBasic;
using System;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;

namespace P04_Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int count = int.Parse(Console.ReadLine());

            int curr = 0;

            for (int counter = 0; counter < count; counter++)
            {
                curr = array[0];
                for (int i = 0; i < array.Length - 1; i++)
                {
                    array[i] = array[i + 1];
                }
                array[array.Length - 1] = curr;
            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
