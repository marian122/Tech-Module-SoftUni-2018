using System;
using System.Collections.Generic;
using System.Linq;

namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            var listOfPeople = new List<string>();

            PeopleGoingToParty(numberOfCommands, listOfPeople);

            foreach (var guest in listOfPeople)
            {
                Console.WriteLine(guest);
            }
        }

        private static List<string> PeopleGoingToParty(int numberOfCommands, List<string> listOfPeople)
        {
            for (int i = 0; i < numberOfCommands; i++)
            {
                string command = Console.ReadLine();

                string name = command.Split(new char[] { ' ' })[0];

                if (command == $"{name} is going!")
                {
                    if (listOfPeople.Exists(x => x.Equals(name)))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                        continue;
                    }
                    listOfPeople.Add(name);
                }
                else if (command.Contains($"{name} is not going!"))
                {
                    if (listOfPeople.Exists(x => x.Equals(name)))
                    {
                        listOfPeople.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }
            return listOfPeople;
        }
    }
}