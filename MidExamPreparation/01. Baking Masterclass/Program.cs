using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Baking_Masterclass
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double flourPrice = double.Parse(Console.ReadLine());
            double eggPrice = double.Parse(Console.ReadLine());
            double aponPrice = double.Parse(Console.ReadLine());
            var studentsDiscount = Math.Ceiling((students + (students * 0.2)));

            if (students >= 5)
            {
                var discount = students - (students / 5);
                var priceNeeded = aponPrice * studentsDiscount + eggPrice * 10 * students + flourPrice * (discount);
                if (budget >= priceNeeded)
                {
                    Console.WriteLine($"Items purchased for {priceNeeded:F2}$.");
                }
                else if (budget <= priceNeeded)
                {
                    var need = priceNeeded - budget;
                    Console.WriteLine($"{need:F2}$ more needed.");
                }
            }
            else
            {
                var priceNeeded = aponPrice * studentsDiscount + eggPrice * 10 * students + flourPrice * (students);
                if (budget >= priceNeeded)
                {
                    Console.WriteLine($"Items purchased for {priceNeeded:F2}$.");
                }
                else if (budget <= priceNeeded)
                {
                    var need = priceNeeded - budget;
                    Console.WriteLine($"{need:F2}$ more needed.");
                }
            }
        }
    }
}
