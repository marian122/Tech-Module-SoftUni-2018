using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace softuniCoursePlaning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lessons = Console.ReadLine().Split(',', ' ').ToList();

            string input = Console.ReadLine();

            while (input != "course start")
            {
                string[] data = input.Split(':');

                string command = data[0];

                if (command == "Add")
                {
                    string title = data[1];

                    if (lessons.Contains(title) == false)
                    {
                        lessons.Add(title);
                    }
                }
                else if (command == "Insert")
                {
                    string title = data[1];
                    int index = int.Parse(data[2]);

                    if (lessons.Contains(title) == false)
                    {
                        if (index >= 0 && index < lessons.Count)
                        {
                            lessons.Insert(index, title);
                        }
                    }

                }
                else if (command == "Remove")
                {
                    string comand = data[1];
                    if (lessons.Contains(comand) == false)
                    {
                        lessons.Remove(comand);
                    }
                }
                input = Console.ReadLine();
            }

            for (int i = 0; i < lessons.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{lessons[i]}");
            }
            

            
        }
    }
}
