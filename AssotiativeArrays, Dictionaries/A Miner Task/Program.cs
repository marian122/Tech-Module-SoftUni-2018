using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<string, int>();
            while (true)
            {
                string material = Console.ReadLine();
                
                if (material == "stop")
                {
                    break;
                }
                int quantity = int.Parse(Console.ReadLine());

                if (!result.ContainsKey(material))
                {
                    result.Add(material, 0);
                }
                    result[material] += quantity;
                
            }
            foreach (var curr in result)
            {
                Console.WriteLine($"{curr.Key} -> {curr.Value}");
            }
        }
    }
}
