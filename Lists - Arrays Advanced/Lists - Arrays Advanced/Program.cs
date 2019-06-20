using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists___Arrays_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrTexts = new string[4];


            List<string> texts = new List<string>();

            texts.Add("1");
            texts.Add("2");
            texts.Remove("2");

            for (int i = 0; i < texts.Count; i++)
            {
                var text = texts[i];
                Console.WriteLine(text);
            }

            foreach (var text in texts)
            {
                Console.WriteLine(text);
            }
        }
        static void Lists()
        {
            int List = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int>();
            for (int i = 0; i < List; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                numbers.Add(currentNumber);
            }
            Console.WriteLine(string.Join(",", numbers));
            while (true)
            {
                string Line = Console.ReadLine();
                if (Line == "END")
                {
                    break;
                }
                //int numbers = int.Parse(Line);
                
            }
        }

    }
}
