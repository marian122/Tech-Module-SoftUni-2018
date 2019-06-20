using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List <double> numbers = Console.ReadLine().
                Split(' ').
                Select(double.Parse).
                ToList();

            if (numbers.Count > 1)
            {

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (i == numbers.Count - 1)
                    {
                        break;
                    }

                    double currentNumber = numbers[i];
                    double nextNumber = numbers[i + 1];

                    if (currentNumber == nextNumber)
                    {
                       numbers[i] += nextNumber;
                       numbers.RemoveAt(i + 1);
                       i = -1;
                    }
                }
                    Console.WriteLine(string.Join(" ", numbers));
            }
            else
            {
                Console.WriteLine(string.Join(" ", numbers));

            }
        }
    }
}
