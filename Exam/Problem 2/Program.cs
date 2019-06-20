using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] events = Console.ReadLine().Split('|');

            int currHealth = 100;
            int currCoins = 0;
            int room = 0;

            for (int i = 0; i < events.Length; i++)
            {
                string[] eachEvent = events[i].Split(' ');
                string comand = eachEvent[0];
                int comandNumber = int.Parse(eachEvent[1]);
                if (comand == "potion")
                {
                    room += 1;
                    if (currHealth + comandNumber <= 100)
                    {
                        currHealth += comandNumber;

                        Console.WriteLine("You healed for {0} hp.", comandNumber);
                        Console.WriteLine("Current health: {0} hp.", currHealth);
                    }
                    else
                    {
                        Console.WriteLine($"You healed for {100 - currHealth} hp.");
                        currHealth = 100;
                        Console.WriteLine("Current health: {0} hp.", currHealth);

                    }
                }
                if (comand == "chest")
                {
                    room += 1;

                    Console.WriteLine($"You found {comandNumber} coins.");
                    currCoins += comandNumber;
                }
                if (comand != "chest" && comand != "potion")
                {
                    currHealth -= comandNumber;
                    room += 1;
                    if (currHealth > 0)
                    {
                        Console.WriteLine($"You slayed {comand}.");
                    }
                    if (currHealth <= 0)
                    { 
                        Console.WriteLine($"You died! Killed by {comand}.");
                        Console.WriteLine($"Best room: {room}");
                        break;
                    }
                }                                
            }
                if (currHealth > 0)
                {
                    Console.WriteLine($"You've made it!");
                    Console.WriteLine($"Coins: {currCoins}");
                    Console.WriteLine($"Health: {currHealth}");                  
                }
        }
    }
}
