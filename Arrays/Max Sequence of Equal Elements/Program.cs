using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int count = 1;
            int tempCount = 1;
            int number = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    tempCount++;
                }
                else
                {
                    tempCount = 1;
                }
                if (tempCount > count)
                {
                    count = tempCount;
                    number = arr[i];
                }
            }
            for (int i = 0; i < count; i++)
            {
                Console.Write("{0} ", number);
                
            }
            Console.WriteLine();
        }
    }
}              