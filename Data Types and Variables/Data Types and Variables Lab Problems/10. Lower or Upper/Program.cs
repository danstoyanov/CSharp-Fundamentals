using System;

namespace _10_Lower_or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputSymbol = Console.ReadLine();

            if (inputSymbol == "a" || inputSymbol == "b" || inputSymbol == "c" || inputSymbol == "d" ||
                inputSymbol == "e" || inputSymbol == "f" || inputSymbol == "g" || inputSymbol == "h" ||
                inputSymbol == "i" || inputSymbol == "j" || inputSymbol == "k" || inputSymbol == "l" ||
                inputSymbol == "m" || inputSymbol == "n" || inputSymbol == "o" || inputSymbol == "p" ||
                inputSymbol == "q" || inputSymbol == "r" || inputSymbol == "s" || inputSymbol == "t" ||
                inputSymbol == "u" || inputSymbol == "v" || inputSymbol == "w" || inputSymbol == "x" ||
                inputSymbol == "y" || inputSymbol == "z")
            {
                Console.WriteLine("lower-case");
            }
            else
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}
