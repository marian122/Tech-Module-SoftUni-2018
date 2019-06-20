﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Song_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {

            string[ input = Console.ReadLine().Split(':').ToArray();

            var print = Caesar(input, 3);
            Console.WriteLine(print);

        }
        static string Caesar(string value, int shift)
        {
            char[] buffer = value.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];

                letter = (char)(letter + shift);

                buffer[i] = letter;
            }
            return new string(buffer);
        }
    }
}
