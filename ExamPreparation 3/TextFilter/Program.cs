﻿using System;
using System.Linq;

namespace TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWord = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string text = Console.ReadLine();

            for (int i = 0; i < bannedWord.Length; i++)
            {
                string currentWord = bannedWord[i];

                if (text.Contains(currentWord))
                {
                    string starsReplace = new string('*', currentWord.Length);

                    text = text.Replace(currentWord, starsReplace);
                }
            }
            Console.WriteLine(text);
        }
    }
}
