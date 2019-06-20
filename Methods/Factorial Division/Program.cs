using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            FactorialDivision();
        }
        public static void FactorialDivision()
        {
            double firstFact = double.Parse(Console.ReadLine());
            double secondFact = double.Parse(Console.ReadLine());
            double firstFactSum = firstFact;
            double secondFactSum = secondFact;

            for (int i = 1; i < firstFact; i++)
            {
                firstFactSum = firstFactSum * i;
            }

            for (int i = 1; i < secondFact; i++)
            {
                secondFactSum = secondFactSum * i;
            }
            double result =firstFactSum / secondFactSum;
            Console.WriteLine("{0:f2}",result);
        }
    }
}
