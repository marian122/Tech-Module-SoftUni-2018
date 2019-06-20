using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_List
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
                else if (command == "Delete")
                {
                    int index = int.Parse(tokens[1]);
                    numbers.RemoveAll(item => item == index);
                }
            }
                    Console.WriteLine(string.Join(" ", numbers));
            
        }
    }
}
