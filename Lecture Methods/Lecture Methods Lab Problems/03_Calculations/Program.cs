using System;

namespace _03_Calculations
{
    class Program
    {
        static void Main()
        {
            string calculation = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Calculation(calculation, a, b);
        }

        static void Calculation(string calculation, int a, int b)
        {
            if (calculation == "add")
            {
                Console.WriteLine(a + b);
            }
            else if (calculation == "multiply")
            {
                Console.WriteLine(a * b);
            }
            else if (calculation == "subtract")
            {
                Console.WriteLine(a - b);
            }
            else if (calculation == "divide")
            {
                Console.WriteLine(a / b);
            }
        }
    }
}
