using System;
using System.Text.RegularExpressions;

namespace AnimalSanctuary
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                var input = Console.ReadLine();

                var match = Regex.Match(input, "[a-zA-Z]+");
            }
        }
    }
}
