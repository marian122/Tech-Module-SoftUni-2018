using System;


namespace snowballs
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;
            int snowCopy = 0;
            int timeCopy = 0;
            int qualityCopy = 0;
            for (int i = 1; i <= n; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());

                int value = int.Pow((snow / time), quality);
                if (value > maxNumber)
                {
                    maxNumber = value;
                    snowCopy = snow;
                    timeCopy = time;
                    qualityCopy = quality;
                }
            }
            Console.WriteLine($"{snowCopy} : {timeCopy} = {maxNumber} ({qualityCopy})");
        }
    }
}