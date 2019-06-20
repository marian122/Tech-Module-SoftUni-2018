using System;
using System.Collections.Generic;
using System.Linq;

namespace VaporWinterSale
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ");

            var noDlcDictionary = new Dictionary<string, decimal>();
            var yesDlcDictionary = new Dictionary<string, string[]>();

            foreach (var game in input)
            {
                if (game.Contains("-"))
                {
                    var tokens = game.Split("-");
                    var name = tokens[0];
                    var price = decimal.Parse(tokens[1]);

                    if (!noDlcDictionary.ContainsKey(name))
                    {
                        noDlcDictionary.Add(name, price);
                    }
                }

                if (game.Contains(":"))
                {
                    var tokens = game.Split(":");
                    var name = tokens[0];
                    var dlc = tokens[1];


                    if (noDlcDictionary.ContainsKey(name))
                    {
                        decimal price = noDlcDictionary[name] + (noDlcDictionary[name] * 0.2m);
                        yesDlcDictionary.Add(name, new string[2]);
                        yesDlcDictionary[name][0] = dlc;
                        yesDlcDictionary[name][1] = price.ToString();

                        noDlcDictionary.Remove(name);
                    }
                }
            }

            foreach (var game in yesDlcDictionary.OrderBy(x => decimal.Parse(x.Value[1])))
            {
                var name = game.Key;
                var dlc = game.Value[0];
                var gamePrice = decimal.Parse(game.Value[1]);
                var price = gamePrice - (gamePrice * 0.5m);
                Console.WriteLine($"{name} - {dlc} - {price:f2}");
            }

            foreach (var game in noDlcDictionary.OrderByDescending(x => x.Value))
            {
                var price = game.Value - (game.Value * 0.2m);

                Console.WriteLine($"{game.Key} - {price:F2}");
            }
        }
    }
}
