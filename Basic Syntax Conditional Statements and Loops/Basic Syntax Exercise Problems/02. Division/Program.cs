using System;

namespace _02_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int numInput = int.Parse(Console.ReadLine());
            int devisibleNum = 0;

            if (numInput % 2 == 0)
            {
                devisibleNum = 2;
            }

            if (numInput % 3 == 0)
            {
                devisibleNum = 3;
            }

            if (numInput % 6 == 0)
            {
                devisibleNum = 6;
            }

            if (numInput % 7 == 0)
            {
                devisibleNum = 7;
            }

            if (numInput % 10 == 0)
            {
                devisibleNum = 10;
            }

            if (devisibleNum == 0)
            {
                Console.WriteLine("Not divisible");
                return;
            }

            Console.WriteLine($"The number is divisible by {devisibleNum}");
        }
    }
}
