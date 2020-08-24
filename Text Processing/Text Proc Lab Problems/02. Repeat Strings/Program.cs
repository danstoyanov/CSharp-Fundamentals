using System;
using System.Linq;
using System.Text;

namespace _02_Repeat_Strings
{
    class Program
    {
        static void Main()
        {
            var words = Console.ReadLine()
                .Split()
                .ToArray();

            var result = new StringBuilder();

            foreach (var word in words)
            {
                int count = word.Length;

                for (int i = 0; i < count; i++)
                {
                    result.Append(word);
                }
            }

            Console.WriteLine(result);
        }
    }
}
