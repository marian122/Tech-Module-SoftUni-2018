using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] specialNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int special = specialNumbers[0];

            int specialPower = specialNumbers[1];

            if (numbers.Contains(special))
            {
                while (true)
                {
                    int indexOfSpecial = numbers.IndexOf(special);

                    int startExplode = indexOfSpecial - specialPower;

                    if (startExplode < 0)
                    {
                        startExplode = 0;
                    }
                    int elementsToRemove = specialPower * 2 + 1;
                    if (startExplode + elementsToRemove > numbers.Count)
                    {
                        elementsToRemove = numbers.Count - startExplode;
                    }

                    numbers.RemoveRange(startExplode, elementsToRemove);
                    if (!numbers.Contains(special))
                    {
                        break;
                    }
                }
                int sum = numbers.Sum();
                Console.WriteLine(sum);
            }

        }
    }
}
