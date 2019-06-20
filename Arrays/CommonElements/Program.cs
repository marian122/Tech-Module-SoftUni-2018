using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstInput = Console.ReadLine();
            string secondInput = Console.ReadLine();

            string[] firstOne = firstInput.Split();
            string[] firstArr = new string[firstOne.Length];

            string[] secondOne = secondInput.Split();
            string[] secondArr = new string[secondOne.Length];

            for (int i = 0; i < secondOne.Length; i++)
            {
                string elementFromFirstArray = secondOne[i];
                for (int j = 0; j < firstOne.Length; j++)
                {
                    string elementFromSecondArray = firstOne[j];
                    if (elementFromFirstArray == firstOne[j])
                    {
                        Console.Write(elementFromFirstArray + ' ');
                    }
                }
            }
                        Console.WriteLine();
        }
    }
}
