using System;
using System.Collections.Generic;
using System.Linq;

namespace FinalExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            var counts = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string toLowerWords = word.ToLower();

                if (counts.ContainsKey(toLowerWords))
                {
                    counts[toLowerWords]++;
                }
                else
                {
                    counts.Add(toLowerWords, 1);
                }
            }
            foreach (var count in counts)
            {
                if (count.Value % 2 == 1)
                {
                    Console.Write(count.Key + " ");
                }
            }

        }
    }
}
            //int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //var counts = new SortedDictionary<double, int>();

            //foreach (var number in numbers)
            //{
            //    if (counts.ContainsKey(number))
            //    {
            //        counts[number]++;
            //    }
            //    else
            //    {
            //        counts.Add(number, 1);
            //    }
            //}
            //foreach (var num in counts)
            //{
            //    Console.WriteLine($"{num.Key} -> {num.Value}");
            //}
