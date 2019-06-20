using System;
using System.Collections.Generic;
using System.Threading;
using System.Globalization;
using System.Linq;

namespace Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            var rnd = new Random();
            
            for (int i = 0; i < input.Length; i++)
            {
               var randomized = rnd.Next(0, input.Length);
                var tempValue = input[i];
                input[i] = input[randomized];
                input[randomized] = tempValue;
            }
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
            }
        }
    }
}
