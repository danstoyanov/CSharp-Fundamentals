using System;
using System.Collections.Generic;

namespace _03_Word_Synonyms
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var wordDict = new Dictionary<string, List<string>>();

            for (int i = 1; i <= n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!wordDict.ContainsKey(word))
                {
                    wordDict.Add(word, new List<string>());
                    wordDict[word].Add(synonym);
                }
                else
                {
                    wordDict[word].Add(synonym);
                }
            }

            foreach (var pair in wordDict)
            {
                Console.WriteLine(pair.Key + " - " + string.Join(", ", pair.Value));
            }
        }
    }
}
