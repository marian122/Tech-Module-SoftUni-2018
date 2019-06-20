using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middle_characters
{
    class Program
    {
        static void Main(string[] args)
        {
            MiddleCharCheck();
        }
        static void MiddleCharCheck()
        {
            string input = Console.ReadLine();
            

            if (input.Length % 2 == 0)
            {
                Console.WriteLine(input.Substring((input.Length / 2) - 1, 2));

            }
            else
            {
                Console.WriteLine(input.Substring((input.Length / 2), 1));

            }
        }
    }
}
