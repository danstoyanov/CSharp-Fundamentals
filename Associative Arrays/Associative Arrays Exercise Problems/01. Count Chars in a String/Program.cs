using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Count_Chars_in_a_String
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();

            var dict = new Dictionary<char, int>();

            foreach (var currElement in text)
            {
                if (currElement != ' ')
                {
                    if (!dict.ContainsKey(currElement))
                    {
                        dict.Add(currElement, 1);
                    }
                    else
                    {
                        dict[currElement]++;
                    }
                }
            }

            foreach (var item in dict)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }
        }
    }
}
