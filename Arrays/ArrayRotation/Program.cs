using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int counter = int.Parse(Console.ReadLine());

            for (int i = 0; i < counter; i++)
            {
                int[] newArr = new int[numbers.Length];
                for (int j  = 0; j  < newArr.Length; j ++)
                {
                    if (j + 1 > newArr.Length - 1)
                    {
                        newArr[j] = numbers[0];
                    }
                    else
                    {
                        newArr[j] = numbers[j + 1];
                    }
                }
                numbers = newArr;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

        }
    }
}
