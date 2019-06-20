using System;
using System.Linq;

namespace Largest_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine().Split(' ').Select(int.Parse).OrderByDescending(x => x).Take(3).ToList().ForEach(x => Console.Write(x + " "));


        }
    }
}
