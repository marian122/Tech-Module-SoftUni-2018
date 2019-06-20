using System;
using System.Collections.Generic;
using System.Linq;

namespace Concert
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> bandNamesArtist = new Dictionary<string, List<string>>();
            Dictionary<string, int> bandTime = new Dictionary<string, int>();
            string input = Console.ReadLine();
            
            while (input != "start of concert")
            {
                string[] tokens = input.Split(";");
                string command = tokens[0];
               
                Dictionary<string, string> newDict = new Dictionary<string, string>();

                if (tokens[0] == "Add")
                {
                    string bandName = tokens[1];
                    string[] members = tokens[2].Split(", ");

                    if (!bandNamesArtist.ContainsKey(bandName))
                    {
                        bandNamesArtist.Add(bandName, new List<string>());
                    }

                    foreach (var member in members)
                    {
                        if (!bandNamesArtist[bandName].Contains(member))
                        {
                            bandNamesArtist[bandName].Add(member);
                        }
                    }
                }

               else if (tokens[0] == "Play")
                {
                    string bandName = tokens[1];
                    int views = int.Parse(tokens[2]);

                    if (!bandTime.ContainsKey(bandName))
                    {
                        bandTime.Add(bandName, 0);
                    }
                    if (!bandNamesArtist.ContainsKey(bandName))
                    {
                        bandNamesArtist.Add(bandName, new List<string>());
                    }
                    bandTime[bandName] += views;

                }


               
                
                input = Console.ReadLine();
            }

            string keyBand = Console.ReadLine();
            int totalTime = bandTime.Values.Sum();

            Console.WriteLine($"Total time: {totalTime}");

            foreach (var item in bandTime.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
            foreach (var kvp in bandNamesArtist)
            {
                if (kvp.Key == keyBand)
                {
                    Console.WriteLine(kvp.Key);
                    foreach (var contest in kvp.Value)
                    {
                        Console.WriteLine($"=> {contest}");
                    }
                }
                
            }

        }
    }
}





