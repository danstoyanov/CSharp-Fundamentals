using System;

namespace _05_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numsInput = int.Parse(Console.ReadLine());
            bool isSpecial = false;

            for (int i = 1; i <= numsInput; i++)
            {
                int currentNumber = i;
                int sum = 0;

                while (currentNumber != 0)
                {
                    sum += (currentNumber % 10);
                    currentNumber /= 10;
                }

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    isSpecial = true;
                }
                else
                {
                    isSpecial = false;
                }

                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
