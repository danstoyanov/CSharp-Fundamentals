using System;

namespace _02_Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal inputGBP = decimal.Parse(Console.ReadLine());
            decimal convertValue = inputGBP * 1.31m;
            // WARNING !!! --> When you use the decimal funcion, add the symbol after the numbers
            // 1 km. ---> 1000.0m    //    2.99m BGN, 3.99m USD ....
            Console.WriteLine($"{convertValue:F3}");
        }
    }
}
