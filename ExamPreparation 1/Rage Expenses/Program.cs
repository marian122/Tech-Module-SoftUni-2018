using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            var headsetBroken = lostGamesCount / 2;
            var mouseBroken = lostGamesCount / 3;
            var keyboardBroken = lostGamesCount / 6;
            var displayBroken = lostGamesCount / 12;

            var sum = headsetBroken * headsetPrice +
                mousePrice * mouseBroken +
                keyboardPrice * keyboardBroken +
                displayPrice * displayBroken;

            Console.WriteLine($"Rage expenses: {sum:F2} lv.");


        }
    }
}
