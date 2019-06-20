using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int smallerNumber = SmallerNumber(firstNumber, secondNumber);
            int result = SmallerNumber(smallerNumber, thirdNumber);
        }
        static int SmallerNumber(int firstNumber, int secondNumber)
        {
            if (firstNumber <= secondNumber)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }
        }
    }
}
