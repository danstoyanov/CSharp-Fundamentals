using System;

namespace _01_Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double max = double.MinValue;
            double min = double.MaxValue;
            double middle = 0;

            double one = double.Parse(Console.ReadLine());

            if (one > max)
            {
                max = one;
            }
            if (one < min)
            {
                min = one;
            }

            double two = double.Parse(Console.ReadLine());

            if (two > max)
            {
                max = two;
            }
            if (two < min)
            {
                min = two;
            }

            double three = double.Parse(Console.ReadLine());

            if (three > max)
            {
                max = three;
            }
            if (three < min)
            {
                min = three;
            }

            if (max == one && min == two)
            {
                middle = three;
            }
            else if (max == one && min == three)
            {
                middle = two;
            }
            else if (max == two && min == one)
            {
                middle = three;
            }
            else if (max == two && min == three)
            {
                middle = one;
            }
            else if (max == three && min == one)
            {
                middle = two;
            }
            else if (max == three && min == two)
            {
                middle = one;
            }

            Console.WriteLine(max);
            Console.WriteLine(middle);
            Console.WriteLine(min);
        }
    }
}
