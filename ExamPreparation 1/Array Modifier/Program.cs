using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            while (true)
            {

                string input = Console.ReadLine();
                string[] tokens = input.Split(' ');
                string command = tokens[0];
                if (input == "end")
                {
                    break;
                }
                else if (command == "swap")
                {
                    int firstNumber = int.Parse(tokens[1]);
                    int secondNumber = int.Parse(tokens[2]);

                    int temp = nums[firstNumber];
                    nums[firstNumber] = nums[secondNumber];
                    nums[secondNumber] = temp;
                    

                }
                else if (command == "multiply")
                {
                    int firstNumber = int.Parse(tokens[1]);
                    int secondNumber = int.Parse(tokens[2]);

                    int temp = nums[firstNumber];
                    temp *= nums[secondNumber];
                    nums[firstNumber] = temp;
                    
                }
                else if (command == "decrease")
                {
                    
                    for (int i = 0; i < nums.Length; i++)
                    {
                        nums[i] -= 1;
                    }

                }
            }
                    Console.WriteLine(string.Join(", ", nums));
            
        }

    }
}
