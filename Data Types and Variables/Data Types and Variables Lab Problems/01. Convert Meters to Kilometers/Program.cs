using System;

namespace _01_Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            // As we know 1000 meters ==> 1 kilometer.... 
            decimal meterInput = decimal.Parse(Console.ReadLine());
            decimal converter = meterInput / 1000;
            // To make correct convert with these inputs, try to use the new variable "decimal" !
            Console.WriteLine($"{converter:F2}");
        }
    }
}
