using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int originalPokePower = pokePower;
            var targetCount = 0;
            
            while (pokePower >= distance)
            {
                pokePower -= distance;
                targetCount++;
                if (originalPokePower * 0.5 == pokePower && exhaustionFactor > 0)
                {
                    pokePower /= exhaustionFactor;
                }
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(targetCount);
            
        }
    }
}
