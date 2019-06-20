using System;
using System.Text;

namespace RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < words.Length; i++)
            {

                int count = words[i].Length;

                for (int j = 0; j < count; j++)
                {
                    result.Append(words[i]);
                }
            }
            
            Console.WriteLine(result.ToString());
        }
    }
}
