using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().
                Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                Select(double.Parse).
                ToList();
            bool change = false;
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
                    change = true;
                }
                else if (command == "RemoveAt")
                {
                    int index = int.Parse(tokens[1]);
                    numbers.RemoveAt(index);
                    change = true;
                }
                else if (command == "Add")
                {
                    int number = int.Parse(tokens[1]);
                    numbers.Add(number);
                    change = true;
                }
                else if (command == "Remove")
                {
                    int number = int.Parse(tokens[1]);
                    numbers.Remove(number);
                    change = true;
                }
                else if (command == "Contains")
                {
                    int number = int.Parse(tokens[1]);
                    if (numbers.Contains(number))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }

                }
                else if (command == "PrintEven")
                {
                    var evenNumbers = numbers.Where(num => num % 2 == 0);
                    Console.WriteLine(string.Join(" ", evenNumbers));

                }
                else if (command == "PrintOdd")
                {
                    var oddNumbers = numbers.Where(num => num % 2 != 0);
                    Console.WriteLine(string.Join(" ", oddNumbers));

                }
                else if (command == "GetSum")
                {
                    int total = numbers.Sum(x => Convert.ToInt32(x));
                    Console.WriteLine(total);
                }
                else if (command == "Filter")
                {
                    string sign = tokens[1];

                    double numberLevel = double.Parse(tokens[2]);

                    List<double> temp = new List<double>();
                    if (sign == ">")
                    {
                        temp = numbers.Where(x => x > numberLevel).ToList();
                    }
                    else if (sign == "<")
                    {
                        temp = numbers.Where(x => x < numberLevel).ToList();
                    }
                    else if (sign == ">=")
                    {
                        temp = numbers.Where(x => x >= numberLevel).ToList();
                    }
                    else if (sign == "<=")
                    {
                        temp = numbers.Where(x => x <= numberLevel).ToList();
                    }
                    
                    Console.WriteLine(string.Join(" ", temp));                   
                }              
            }
            if (change)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
