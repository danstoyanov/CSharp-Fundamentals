using System;

namespace _12_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int numInput = int.Parse(Console.ReadLine());

            while (numInput % 2 != 0)
            {
                Console.WriteLine("Please write an even number.");


                numInput = int.Parse(Console.ReadLine());
            }

            if (numInput % 2 == 0)
            {
                Console.WriteLine($"The number is: {Math.Abs(numInput)}");
            }
        }
    }
}
