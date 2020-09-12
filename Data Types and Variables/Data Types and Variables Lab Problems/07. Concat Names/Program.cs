using System;

namespace _07_Concat_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string symbol = Console.ReadLine();

            Console.WriteLine($"{firstName}{symbol}{lastName}");
        }
    }
}
