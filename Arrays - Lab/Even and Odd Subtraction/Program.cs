using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int evenSum = 0;
            int oddSum = 0;
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int currentNumber = nums[i];
                if (currentNumber % 2 == 0)
                {
                    evenSum += currentNumber;
                }
                if (currentNumber % 2 != 0)
                {
                    oddSum += currentNumber;

                }
            }
            Console.WriteLine(evenSum - oddSum);
        }
    }
}
