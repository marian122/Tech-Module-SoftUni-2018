using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();
            
            var counts = new Dictionary<char, int>();

            for (int i = 0; i < words.Length; i++)
            {
                char current = words[i];
                if (current == ' ')
                {
                    continue;
                }
                if (!counts.ContainsKey(current))
                {
                    counts.Add(current, 0);
                }
                counts[current] += 1;
            }  
               
            foreach (var num in counts)
            {
                
                Console.WriteLine($"{num.Key} -> {num.Value}");
            }
        }
    }
}
