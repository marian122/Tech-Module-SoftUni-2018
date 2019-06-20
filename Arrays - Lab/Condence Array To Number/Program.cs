using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condence_Array_To_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int index = 0;

            while (array.Count > 1)
            {
                if (index == array.Count - 1)
                {
                    array.RemoveAt(index);
                    index = 0;
                    continue;
                }
                array[index] += array[index + 1];
                index++;
            }
            Console.WriteLine(array[0]);
        }
    }
}
