using System;
using System.Numerics;

namespace _03_Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersInput = int.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 1; i <= numbersInput; i++)
            {
                decimal inputNum = decimal.Parse(Console.ReadLine());
                sum += inputNum;
            }

            Console.WriteLine(sum);
        }
    }
}
