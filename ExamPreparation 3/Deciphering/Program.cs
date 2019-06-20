using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace Deciphering
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstInput = Console.ReadLine();
            string[] secondInput = Console.ReadLine().Split(" ").ToArray();

            string firstSubstring = secondInput[0];
            string secondSubstring = secondInput[1];

            string pattern = @"(?<validation>[d-z{}#|]+)";
            var regex = new Regex(pattern);
            StringBuilder decrypted = new StringBuilder();

            for (int i = 0; i < firstInput.Length; i++)
            {
                char symbol = firstInput[i];

                if (regex.IsMatch(symbol.ToString()) == false)
                {
                    Console.WriteLine($"This is not the book you are looking for.");
                    return;
                }
                else
                {
                    symbol -= (char)3;
                    decrypted.Append(symbol);
                }

            }

            string print = decrypted.Replace(firstSubstring, secondSubstring).ToString();
            Console.WriteLine(print);
        }
    }
}
