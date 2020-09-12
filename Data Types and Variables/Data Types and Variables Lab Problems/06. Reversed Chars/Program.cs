using System;

namespace _06_Reversed_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstInput = char.Parse(Console.ReadLine());
            char middleInput = char.Parse(Console.ReadLine());
            char lastInput = char.Parse(Console.ReadLine());

            Console.WriteLine($"{lastInput} {middleInput} {firstInput}");
        }
    }
}
