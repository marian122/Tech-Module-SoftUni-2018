using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweet_Dessert
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            var guestsCount = int.Parse(Console.ReadLine());
            double bananaPrice = double.Parse(Console.ReadLine());
            double eggPrice = double.Parse(Console.ReadLine());
            double berryPrice = double.Parse(Console.ReadLine());

            var portions = Math.Ceiling(guestsCount / 6d);
            var total = portions * (2 * bananaPrice) + portions * (4 * eggPrice) + portions * (0.2 * berryPrice);

            if (budget >= total)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {total:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {total - budget:F2}lv more.");
            }
        }
    }
}
