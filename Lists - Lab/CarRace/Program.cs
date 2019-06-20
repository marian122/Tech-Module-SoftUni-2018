using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().
                Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToList();

            var oneHalf = list.Select((x, i) => new { x, i }).Where(t => t.i % 2 == 0).Select(t => t.x);
            var otherHalf = list.Select((x, i) => new { x, i }).Where(t => t.i % 2 != 0).Select(t => t.x);
            Console.WriteLine(string.Join(" ", oneHalf));
            Console.WriteLine(string.Join(" ", otherHalf));


        }
    }
}
