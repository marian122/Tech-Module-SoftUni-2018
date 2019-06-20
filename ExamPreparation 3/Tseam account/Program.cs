using System;
using System.Collections.Generic;
using System.Linq;

namespace Tseam_account
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> account = Console.ReadLine().Split().ToList();
            List<string> installedGames = new List<string>();

            string input = Console.ReadLine();

            while (input != "Play!")
            {
                string[] tokens = input.Split();
                string command = tokens[0];
                string game = tokens[1];

                
                if (command == "Install")
                {
                    if (installedGames.Contains(game) == false)
                    {
                        account.Add(game);
                        installedGames.Add(game);
                    }
                }
                else if (command == "Uninstall")
                {
                    if (account.Contains(game))
                    {
                        account.Remove(game);
                    }
                }
                else if (command == "Update")
                {

                    if (account.Contains(game))
                    {
                        account.Remove(game);
                        account.Add(game);
                    }
                }
                else if (command == "Expansion")
                {
                    string[] tok = game.Split('-');
                    string gameName = tok[0];
                    string expansion = tok[1];

                    if (account.Contains(gameName))
                    {
                        int index = account.IndexOf(gameName);
                        string value = $"{gameName}:{expansion}";
                        if (index == account.Count - 1)
                        {
                            account.Add(value);
                        }
                        else
                        {
                            account.Insert(index + 1, value);
                        }
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", account));
        }
    }
}