using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Baking_Rush
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] events = Console.ReadLine().Split('|');

            int currEnergy = 100;
            int currCoins = 100;

            for (int i = 0; i < events.Length; i++)
            {
                string[] eachEvent = events[i].Split('-');
                string comand = eachEvent[0];
                int comandNumber = int.Parse(eachEvent[1]);

                if (comand == "rest")
                {

                    if (currEnergy + comandNumber <= 100)
                    {

                        currEnergy += comandNumber;
                        
                        Console.WriteLine("You gained {0} energy.", comandNumber);
                    }
                    else
                    {
                        Console.WriteLine("You gained 0 energy.");
                    }
                    Console.WriteLine("Current energy: {0}.", currEnergy);
                    

                }
                if (comand == "order")
                {
                    
                    if (currEnergy >= 30)
                    {
                        Console.WriteLine("You earned {0} coins.", comandNumber);
                        currCoins += comandNumber;
                        currEnergy -= 30;
                    }
                    else if (currEnergy < 30)
                    {
                        currEnergy += 50;
                        Console.WriteLine("You had to rest!");
                    }
                    
                }
                if (comand != "order" && comand != "rest")
                {

                    if (currCoins - comandNumber > 0)
                    {
                        currCoins -= comandNumber;
                        Console.WriteLine("You bought {0}.", comand);
                    }
                    else
                    {
                        Console.WriteLine("Closed! Cannot afford {0}.", comand);
                        break;
                    }
                    
                }
                
            if (i == events.Length - 1)
            {
                Console.WriteLine("Day completed!");
                Console.WriteLine($"Coins: {currCoins}");
                Console.WriteLine($"Energy: {currEnergy}");
            }
            }
        }
    }
}
