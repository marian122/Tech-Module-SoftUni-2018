using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            if (n == 0)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(Fib(n));
            }


        }
        static int Fib(int n)
        {
            int[] arr = new int[n + 1];
            arr[0] = 1;

            for (int i = 1; i <= n; i++)
                for (int j = (i - 2 >= 0) ? i - 2 : 0; j <= i - 1; j++)
                    arr[i] += arr[j];

            return arr[n - 1];
        }

    }
}
