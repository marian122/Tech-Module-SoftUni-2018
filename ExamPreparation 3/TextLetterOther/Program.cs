using System;

namespace TextLetterOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string current = Console.ReadLine();

            string digit = "";
            string word = "";
            string character = "";

            foreach (var symbol in current)
            {
                if (char.IsDigit(symbol))
                {
                    digit += symbol;
                }
                else if (char.IsLetter(symbol))
                {
                    word += symbol;
                }
                else
                {
                    character += symbol;
                }
            }
            Console.WriteLine(digit);
            Console.WriteLine(word);
            Console.WriteLine(character);
        }
    }
}
