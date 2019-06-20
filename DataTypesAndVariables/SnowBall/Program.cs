using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SnowBall
{
    class Program
    {
        static void Main(string[] args)
        {
            var snowballsCount = int.Parse(Console.ReadLine());
            BigInteger snowballValue = 0;
            var snowballSnow = 0;
            var snowballTime = 0;
            var snowballQuality = 0;
            for (int i = 1; i <= snowballsCount; i++)
            {
                var snow = int.Parse(Console.ReadLine());
                var time = int.Parse(Console.ReadLine());
                var quality = int.Parse(Console.ReadLine());

                BigInteger Value = BigInteger.Pow((snow / time), quality);

                if (Value > snowballValue)
                {
                    snowballSnow = snow;
                    snowballTime = time;
                    snowballQuality = quality;
                    snowballValue = Value;
                }
            }
            Console.WriteLine("{0} : {1} = {2} ({3})", snowballSnow, snowballTime, snowballValue, snowballQuality);      
        }
    }
}
