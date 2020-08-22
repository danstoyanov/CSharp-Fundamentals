using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .ToLower()
                .Split()
                .ToList();

            var dictWords = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!dictWords.ContainsKey(word))
                {
                    dictWords.Add(word, 1);
                }
                else
                {
                    dictWords[word]++;
                }
            }

            foreach (var word in dictWords)
            {
                if (word.Value % 2 != 0)
                {
                    Console.Write(word.Key + " ");
                }
            }
        }
    }
}
