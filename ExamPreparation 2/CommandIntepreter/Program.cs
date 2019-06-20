using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CommandIntepreter
{
    class Program
    {
        static void Main(string[] args)
        {
            var danka = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> theNewStr = new List<string>();
            string input = Console.ReadLine();
            
            while (true)
            {
                string[] data = input.Split(' ').ToArray();
               
                if (input == "end")
                {
                    break;
                }
                if (data[0] == "reverse")
                {
                    int start = int.Parse(data[2]);
                    int count = int.Parse(data[4]);

                    if (start < 0 || start >= danka.Count || (start + count) > danka.Count || count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    else
                    {
                        danka.Reverse(start, count);
                    }
                    //Console.WriteLine(string.Join(" ", danka));
                }
                else if (data[0] == "sort")
                {
                    int start = int.Parse(data[2]);
                    int count = int.Parse(data[4]);
                    if (start < 0 || start >= danka.Count || (start + count) > danka.Count || count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    else
                    {

                       theNewStr = danka.Skip(start).Take(count).OrderBy(str => str).ToList();
                        danka.RemoveRange(start, count);
                        danka.InsertRange(start, theNewStr);
                    }
                    //Console.WriteLine(string.Join(" ", danka));
                }
                else if (data[0] == "rollLeft")
                {
                    int start = int.Parse(data[1]);
                    if (start < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    else
                    {
                        start = start % danka.Count;
                        for (int i = 0; i < start; i++)
                        {
                            danka.Insert(danka.Count, danka[0]);
                            danka.RemoveAt(0);
                        }
                    }

                }
                else if (data[0] == "rollRight")
                {
                    int start = int.Parse(data[1]);
                    if (start < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    else
                    {
                        start = start % danka.Count;
                        for (int i = 0; i < start; i++)
                        {
                            danka.Insert(0, danka[danka.Count - 1]);
                            danka.RemoveAt(danka.Count - 1);
                        }
                    }
                }
                    input = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ", danka)}]");

        }

    }
}
