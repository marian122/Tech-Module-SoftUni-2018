using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron_Girder
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();


            for (int i = 0; i < input.Count; i++)
            {
                string[] eachEvent = input[i].Split(':');
                int[] time = input[i]
                    .Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                string comand = eachEvent[0];


                
            }
        }
    }
}
