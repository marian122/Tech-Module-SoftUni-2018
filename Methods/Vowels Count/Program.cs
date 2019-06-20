using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            vowelsCounting();
        }
        private static void vowelsCounting()
        {
            string text = Console.ReadLine().ToLower();
            int vowelCount = 0;

            for (int i = 0; i < text.Length; i++)
            {
                string letter = text[i].ToString();

                if ("aeiou".Contains(letter))
                {
                    vowelCount++;
                }
            }
            Console.WriteLine(vowelCount);

        }
    }
}
