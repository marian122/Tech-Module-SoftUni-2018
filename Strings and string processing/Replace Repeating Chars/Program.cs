using System;
using System.Text;

namespace Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (i == input.Length - 1)
                {
                    sb.Append(input[i]);
                    break;
                }

                char currentChar = input[i];
                char nextChar = input[i + 1];

                if (currentChar != nextChar)
                {
                    sb.Append(currentChar);
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
