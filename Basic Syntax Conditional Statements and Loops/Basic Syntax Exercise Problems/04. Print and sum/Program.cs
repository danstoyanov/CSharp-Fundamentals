using System;

namespace _04_Print_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumCount = int.Parse(Console.ReadLine());
            int endNumInput = int.Parse(Console.ReadLine());

            int sum = 0;
            int firstCounterNum = 0;

            for (int numCount = startNumCount; numCount <= endNumInput; numCount++)
            {
                firstCounterNum = numCount;
                sum += firstCounterNum;

                Console.Write($"{numCount} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}