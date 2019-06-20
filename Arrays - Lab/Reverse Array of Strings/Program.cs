using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] chars = Console.ReadLine().Split().ToArray();

            for (int i = chars.Length - 1; i >= 0; i--)
            {
                Console.Write(chars[i] + " ");
            }
            Console.WriteLine();

        }
    }
}
