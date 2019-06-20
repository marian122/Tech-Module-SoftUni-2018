using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Top_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            for (int i = 0; i < numbers.Length; i++)
            {
                int number = numbers[i];
                for (int j  = i + 1; j  < numbers.Length; j ++)
                {
                    int secNumber = numbers[j];
                    if (number<= secNumber)
                    {
                        break;
                    }
                    else if (j == numbers.Length - 1)
                    {
                        Console.Write(number + " ");
                    }
                }

            }
            Console.WriteLine(numbers[numbers.Length - 1]);

        }
    }
}
