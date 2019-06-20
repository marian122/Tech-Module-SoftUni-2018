using System;
using System.Text.RegularExpressions;
using System.Text;
using System.Linq;

namespace _1._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string paternValid = @"[A-Za-z0-9_-]+";

            Regex reg = new Regex(paternValid);

            for (int i = 0; i < input.Count; i++)
            {
                string current = input[i];

                var match = reg.Match(current);

                if (match.Length == current.Length && (current.Length >= 3 && current.Length <= 16))
                {
                    Console.WriteLine(current);
                }
            }
        }
    }
}

