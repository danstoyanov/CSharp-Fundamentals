using System;

namespace _08_Town_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            string townInput = Console.ReadLine();
            int populationInput = int.Parse(Console.ReadLine());
            decimal areaInput = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Town {townInput} has population of {populationInput} and area {areaInput} square km.");
        }
    }
}
