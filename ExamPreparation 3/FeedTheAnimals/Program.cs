using System;
using System.Collections.Generic;
using System.Linq;

namespace FeedTheAnimals
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(":", StringSplitOptions.RemoveEmptyEntries);
            var hungryCount = 0;
            var dict = new Dictionary<string, Dictionary<string, int>>();
            var hungryDict = new Dictionary<string, int>();

            while (input[0] != "Last Info")
            {
                var command = input[0];

                var animalName = input[1];
                var foodLimit = int.Parse(input[2]);
                var area = input[3];

                if (command == "Add")
                {

                    if (!hungryDict.ContainsKey(area))
                    {
                        hungryDict.Add(area, hungryCount);

                    }

                    if (!dict.ContainsKey(animalName))
                    {
                        dict.Add(animalName, new Dictionary<string, int>());
                        dict[animalName].Add(area, foodLimit);

                        if (dict.ContainsKey(animalName))
                        {
                            if (dict[animalName].ContainsKey(area))
                            {
                                if (dict[animalName][area] > 0)
                                {
                                    if (hungryDict.ContainsKey(area))
                                    {

                                        hungryCount = 1;
                                        hungryDict[area]++;
                                        hungryCount = 0;
                                    }

                                }

                            }
                        }

                        input = Console.ReadLine().Split(":", StringSplitOptions.RemoveEmptyEntries);
                        continue;
                    }

                    if (dict.ContainsKey(animalName))
                    {

                        dict[animalName][area] += foodLimit;

                    }

                }

                else if (command == "Feed")
                {

                    if (dict.ContainsKey(animalName))
                    {
                        dict[animalName][area] -= foodLimit;

                        if (dict[animalName][area] <= 0)
                        {
                            Console.WriteLine($"{animalName} was successfully fed");
                            hungryDict.Remove(area);
                            dict.Remove(animalName);

                        }

                    }
                }

                input = Console.ReadLine().Split(":", StringSplitOptions.RemoveEmptyEntries);

            }

            Console.WriteLine("Animals:");

            foreach (var animal in dict.OrderByDescending(x => x.Key))
            {
                foreach (var item in animal.Value)
                {
                    Console.WriteLine($"{animal.Key} -> {item.Value:F0}g");

                }
            }

            Console.WriteLine("Areas with hungry animals:");

            foreach (var animal in hungryDict.OrderByDescending(x => x.Value))
            {
                
                Console.WriteLine($"{animal.Key} : {animal.Value}");

            }
        }
    }
}
