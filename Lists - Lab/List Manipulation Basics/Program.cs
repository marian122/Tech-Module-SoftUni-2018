using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().
                Split().
                Select(int.Parse).
                ToList();
            while (true)
            {
                string input = Console.ReadLine();
                string[] tokens = input.Split(' ');
                string command = tokens[0];
                if (input == "end")
                {
                    break;
                }
                else if (command == "Insert")
                {
                    int number = int.Parse(tokens[1]);
                    int index = int.Parse(tokens[2]);
                    numbers.Insert(index, number);
                }
                else if (command == "RemoveAt")
                {
                    int index = int.Parse(tokens[1]);
                    numbers.RemoveAt(index);
                }
                else if (command == "Add")
                {
                    int number = int.Parse(tokens[1]);
                    numbers.Add(number);
                }
                else if (command == "Remove")
                {
                    int number = int.Parse(tokens[1]);
                    numbers.Remove(number);
                }

            }
                Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
