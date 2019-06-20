using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            int marathonDay = int.Parse(Console.ReadLine());
            int runnerCount = int.Parse(Console.ReadLine());
            int averageNumber = int.Parse(Console.ReadLine());
            int lapLength = int.Parse(Console.ReadLine());
            int trackCapacity = int.Parse(Console.ReadLine());
            double moneyPerKm = double.Parse(Console.ReadLine());

            var totalMeters = runnerCount * marathonDay * lapLength;
            var totalKm = totalMeters / 1000;
            var moneyRaisedinKM = totalKm * moneyPerKm;
            Console.WriteLine("Money raised: {0:f2}", moneyRaisedinKM);
        }
    }
}
