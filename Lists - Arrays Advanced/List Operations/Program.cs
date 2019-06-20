using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();


            while (true)
            {
                string input = Console.ReadLine();
                string[] tokens = input.Split(' ');
                string command = tokens[0];
                if (input == "End")
                {
                    break;
                }
                else if (command == "Add")
                {
                    int number = int.Parse(tokens[1]);
                    numbers.Add(number);
                }
                else if (command == "Insert")
                {
                    int number = int.Parse(tokens[1]);
                    int index = int.Parse(tokens[2]);
                    if (index > numbers.Count - 1 || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.Insert(index, number);
                }
                else if (command == "Remove")
                {
                    int index = int.Parse(tokens[1]);
                    if (index > numbers.Count - 1 || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.RemoveAt(index);
                }
               else if (command == "Shift")
                {
                    string leftOrRight = tokens[1];
                    int rotations = int.Parse(tokens[2]);

                    if (leftOrRight == "left")
                    {
                        for (int i = 0; i < rotations; i++)
                        {
                            int firstNumber = numbers[0];

                            for (int k = 0; k < numbers.Count - 1; k++)
                            {
                                numbers[k] = numbers[k + 1];
                            }

                            numbers[numbers.Count - 1] = firstNumber;
                        }
                    }

                    else if (leftOrRight == "right")
                    {
                        for (int i = 0; i < rotations; i++)
                        {
                            int lastNumber = numbers[numbers.Count - 1];

                            for (int k = numbers.Count - 1; k > 0; k--)
                            {
                                numbers[k] = numbers[k - 1];
                            }

                            numbers[0] = lastNumber;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
