using System;
using System.Text;

namespace StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            bool bomb = false;

            int power = 0;            

            var sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                char bombCommand = input[i];

                if (bombCommand == '>')
                {
                    bomb = true;
                    power += int.Parse(input[i + 1].ToString());
                    sb.Append(bombCommand);
                    continue;                
                }

                if (bomb == true && power > 0)
                {
                    power--;
                    if (power <= 0)
                    {
                        bomb = false;
                        power = 0;
                    }
                    continue;
                }

                if (bomb == false)
                {
                    sb.Append(bombCommand);
                }

            }

            Console.WriteLine(sb.ToString());
        }
    }
}
