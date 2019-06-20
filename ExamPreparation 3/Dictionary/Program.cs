using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionaryy
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, List<string>>();

            string[] firstInput = Console.ReadLine().Split(" | ").ToArray();
            string[] secondInput = Console.ReadLine().Split(" | ").ToArray();
            string thirdInput = Console.ReadLine();
            for (int i = 0; i < firstInput.Length; i++)
            {
                string[] tokens = firstInput[i].Split(": ").ToArray();
                string word = tokens[0];
                string definition = tokens[1];

                if (!dict.ContainsKey(word))
                {
                    dict.Add(word, new List<string>());
                }
                dict[word].Add(definition);
            }
            
            for (int i = 0; i < secondInput.Length; i++)
            {
                string keyWord = secondInput[i];

                if (dict.ContainsKey(keyWord))
                {
                    foreach (var kvp in dict)
                    {
                        Console.WriteLine($"{kvp.Key}");
                        foreach (var item in kvp.Value.OrderByDescending(x => x.Length))
                        {
                            Console.WriteLine($" -{item}");
                        }
                    }
                }
            }
            
            if (thirdInput == "End")
            {
                return;
            }
            else
            {
                foreach (var item in dict.OrderBy(x => x.Key))
                {
                    Console.Write($"{item.Key} ");
                }
                Console.WriteLine();
            }

        }
    }
}
