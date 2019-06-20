using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());

            int rest = wingFlaps / endurance;
            long seconds = rest * 5L;
            var totalDistance = (wingFlaps / 1000) * distance;
            seconds += wingFlaps / 100;
            Console.WriteLine("{0:f2} m.", totalDistance);
            Console.WriteLine("{0} s.", seconds);
        }
    }
}
