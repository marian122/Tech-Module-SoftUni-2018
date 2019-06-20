using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());

            for (int i = 8; i < range; i++)
            {
                int num = i;
                bool IsSumEqual8 = isSumEqual8(i);
                bool IsOddDigit = isOddDigit(i);

                if ((IsSumEqual8 && IsOddDigit))
                {
                    Console.WriteLine(i);
                }
            }

        }

        private static bool isOddDigit(int number)
        {
            while (number != 0)
            {
                int digit = number % 10;
                number /= 10;

                if (digit % 2 != 0)
                {
                    return true;
                }
            }

            return false;
        }
       private static bool isSumEqual8(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                int digit = number % 10;
                number /= 10;

                sum += digit;
            }
            if (sum % 8 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
