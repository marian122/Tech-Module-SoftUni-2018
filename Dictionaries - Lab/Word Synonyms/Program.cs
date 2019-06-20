using System;
using System.Collections.Generic;

namespace Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, List<string>>();

            for (int i = 0; i < count; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();


                if (!dict.ContainsKey(word))
                {
                    dict.Add(word, new List<string>());
                }
                dict[word].Add(synonym);
            }
                foreach (var kvp in dict)
                {
                    Console.WriteLine($"{kvp.Key} - {string.Join(", ", kvp.Value)}");
                }
        }
    }
}
