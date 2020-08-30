using System;

namespace _11_Multiplication_Table_2_0
{
    class Program
    {
        static void Main(string[] args)
        {
            int numInput = int.Parse(Console.ReadLine());
            int multiNumInput = int.Parse(Console.ReadLine());

            int result = 0;

            if (multiNumInput > 10)
            {
                result = numInput * multiNumInput;
                Console.WriteLine($"{numInput} X {multiNumInput} = {result}");
                return;
            }

            for (int repeatNums = multiNumInput; repeatNums <= 10; repeatNums++)
            {
                result = numInput * repeatNums;
                Console.WriteLine($"{numInput} X {repeatNums} = {result}");
            }
        }
    }
}
