using System;
using System.Linq;

namespace Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] path = Console.ReadLine().Split('\\').ToArray();

            string[] fileAndExtension = path[path.Length - 1].Split('.');

            Console.WriteLine($"File name: {fileAndExtension[0]}");
            Console.WriteLine($"File extension: {fileAndExtension[1]}");

        }
    }
}
