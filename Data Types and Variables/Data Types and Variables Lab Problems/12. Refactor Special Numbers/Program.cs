using System;

namespace _12_Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numInpur = int.Parse(Console.ReadLine());

            int currentNum = 0;
            bool isSpecial = false;

            for (int i = 1; i <= numInpur; i++)
            {
                currentNum = i;
                int sum = 0;

                while (currentNum != 0)
                {
                    sum += (currentNum % 10);
                    currentNum /= 10;
                }

                if ((sum == 5) || (sum == 7) || (sum == 11))
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
