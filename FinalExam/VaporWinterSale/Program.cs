using System;
using System.Collections.Generic;
using System.Linq;

namespace VaporWinterSale
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");

            Dictionary<string, string[]> gameWithDlc = new Dictionary<string, string[]>();
            Dictionary<string, decimal> gameWithoutDlc = new Dictionary<string, decimal>();

            
            foreach(var game in input)
            {

                if (game.Contains('-'))
                {
                    string[] tokens = game.Split('-');
                    string gameName = tokens[0];
                    decimal price = decimal.Parse(tokens[1]);

                    if (!gameWithoutDlc.ContainsKey(gameName))
                    {
                        gameWithoutDlc.Add(gameName, price);
                    }
                }
                else if (game.Contains(':'))
                {
                    string[] tokens = game.Split(':');
                    string gameName = tokens[0];
                    string gameDLC = tokens[1];

                    if (gameWithoutDlc.ContainsKey(gameName))
                    {
                        decimal price = gameWithoutDlc[gameName] + (gameWithoutDlc[gameName] * 0.2m);
                        gameWithDlc.Add(gameName, new string[2]);
                        gameWithDlc[gameName][0] = gameDLC;
                        gameWithDlc[gameName][1] = price.ToString();
                        gameWithoutDlc.Remove(gameName);


                    }
                }
            }
            foreach (var game in gameWithDlc.OrderBy(p => decimal.Parse(p.Value[1])))
            {
                string gameName = game.Key;
                decimal gamePrice = decimal.Parse(game.Value[1]);
                decimal totalPrice = gamePrice - gamePrice * 0.5m;
                Console.WriteLine($"{gameName} - {game.Value[0]} - {totalPrice:f2}");
            }

            foreach (var game in gameWithoutDlc.OrderByDescending(p => p.Value))
            {
                decimal totalPrice = game.Value - (game.Value * 0.2m);
                Console.WriteLine($"{game.Key} - {totalPrice:f2}");
            }
        }
    }
}
