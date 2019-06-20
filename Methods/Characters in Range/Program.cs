using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            rangeBetweenCharactersPrinted();
        }
        private static void rangeBetweenCharactersPrinted()
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            if (secondChar > firstChar)
            {
                for (int i = firstChar + 1; i < secondChar; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
            else if (firstChar > secondChar)
            {
                for (int i = secondChar + 1; i < firstChar; i++)
                {
                    Console.Write((char)i+ " ");
                }
            }
            Console.WriteLine();
        }
        
    }
}
