using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace _5._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine();

            int secondNumber = int.Parse(Console.ReadLine());

            string result = "";
            int firstDigit = 0;

            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {

                int currDig = int.Parse(firstNumber[i].ToString());

                int multiplySecondNum = currDig * secondNumber;

                multiplySecondNum += firstDigit;

                if (multiplySecondNum < 10)
                {
                    result = multiplySecondNum + result;
                }

                else if (multiplySecondNum >= 10)
                {
                    int secondDigit = multiplySecondNum % 10;

                    result = secondDigit + result;
                }

                firstDigit = multiplySecondNum / 10;
            }

            if (firstDigit != 0)
            {
                result = firstDigit + result;
            }

            if (result.All(x => x == '0'))

            {
                result = "0";
                Console.WriteLine(result);
                return;
            }

            Console.WriteLine(result);
        }
    }
}
