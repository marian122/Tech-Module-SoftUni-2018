using System;
using System.Collections.Generic;
using System.Linq;

namespace Multiply_chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(" ");

            string first = data[0];
            string second = data[1];

            int minLength = Math.Min(first.Length, second.Length);

            long sum = 0;

            for (int i = 0; i < minLength; i++)
            {
                int firstLine = first[i];
                int secondLine = second[i];

                sum += firstLine * secondLine;
            }

            string getOtherSymbols = "";
            if (first.Length > second.Length)
            {
                getOtherSymbols = first.Substring(minLength);
            }
            else if (second.Length > first.Length)
            {
                getOtherSymbols = second.Substring(minLength);
            }
            for (int i = 0; i < getOtherSymbols.Length; i++)
            {
                sum += getOtherSymbols[i];
            }
            Console.WriteLine(sum);
        }
    }
}
