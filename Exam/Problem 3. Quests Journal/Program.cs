using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MiddExamm
{
    class Program
    {
        static void Main()
        {
            List<string> lessons = Console.ReadLine().Split(", ").ToList();

            string input = Console.ReadLine();
            while (true)
            {
                string[] data = input.Split(" - ");

                string command = data[0];


                if (input == "Retire!")
                {
                    break;
                }


                else if (command == "Start")
                {
                    string quest = data[1];

                    if (!lessons.Contains(quest))
                    {

                        lessons.Add(quest);
                    }

                }
                else if (command == "Complete")
                {
                    string quest = data[1];
                    if (lessons.Contains(quest))
                    {
                        lessons.Remove(quest);
                    }
                }
                else if (command == "Side Quest")
                {
                    string[] questSide = data[1].Split(":");
                    string questt = questSide[0];
                    string questt1 = questSide[1];

                    if (lessons.Contains(questt))
                    {
                        if (!lessons.Contains(questt1))
                        {
                            lessons.Insert(lessons.IndexOf(questt) - 1, questt1);
                        }
                        
                    }
                           
                }
                else if (command == "Renew")
                {
                    string quest = data[1];

                    if (lessons.Contains(quest))
                    {
                        lessons.Remove(quest);
                        lessons.Add(quest);
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", lessons));
        }
    }
}