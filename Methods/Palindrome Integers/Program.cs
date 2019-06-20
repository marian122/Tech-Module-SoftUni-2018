using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string word = Console.ReadLine();
                if (word == "END")
                {
                    break;
                }
                string reversedWord = ReversedWord(word);
                
                bool isPalindrom = IsPalindrom(word, reversedWord);
                Console.WriteLine(isPalindrom == true ? "true" : "false" );
            }
        }
        private static string ReversedWord(string word)
        {
            string reversedWord = string.Empty;
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversedWord += word[i];
            }
            return reversedWord;
        }
        static bool IsPalindrom(string word, string reversedWord)
        {
            return word == reversedWord;
        }
        
    }
}
