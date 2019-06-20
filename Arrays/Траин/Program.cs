using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Траин
{
    class Program
    {
        static void Main(string[] args)
        {
            var vagonCount = int.Parse(Console.ReadLine());
            int[] numbers = new int[vagonCount];
            var sum = 0;
            for (int i = 0; i < vagonCount; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());  
            }
            for (int i = 0; i < vagonCount; i++)
            {
                Console.Write(numbers[i] + " ");
                sum += numbers[i];              
            }
            Console.WriteLine();
                Console.WriteLine(sum);                  
        }
    }
}
