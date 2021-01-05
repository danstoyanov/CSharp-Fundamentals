using System;

namespace P02_Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arratText01 = Console.ReadLine().Split();
            string[] arratText02 = Console.ReadLine().Split();

            string collectWords = string.Empty;

            for (int i = 0; i < arratText02.Length; i++)
            {
                for (int j = 0; j < arratText01.Length; j++)
                {
                    if (arratText02[i] == arratText01[j])
                    {
                        collectWords += arratText02[i] + " ";
                    }
                }
            }

            Console.WriteLine(collectWords);
        }
    }
}
