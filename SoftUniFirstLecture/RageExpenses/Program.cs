using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            var headsetBroken = lostGames / 2;
            var mouseBroken = lostGames / 3;
            var keyboardBroken = lostGames / 6;
            var displayBroken = lostGames / 12;

            var sum = headsetPrice * headsetBroken +
                mousePrice * mouseBroken +
                keyboardPrice * keyboardBroken +
                displayPrice * displayBroken;

            Console.WriteLine("Rage expenses: {0:f2} lv.", sum);

        }
    }
}
