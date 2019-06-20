using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int partySize = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            decimal coinss = 0;

            for (int i = 1; i <= days; i++)
            {
                if (i != 1)
                {
                    if (i % 10 == 0)
                    {
                        partySize -= 2;
                    }
                    if (i % 15 == 0)
                    {
                        partySize += 5;
                    }
                }

                coinss += 50;

                coinss -= 2 * partySize;

                if (i != 1)
                {

                    if (i % 3 == 0)
                    {
                        coinss -= 3 * partySize;
                    }
                    if (i % 5 == 0)
                    {
                        coinss += 20 * partySize;
                        if (i % 3 == 0)
                        {
                            coinss -= partySize * 2;
                        }

                    }

                }


            }
            decimal coins = Math.Floor(coinss / partySize);
            Console.WriteLine($"{partySize} companions received {coins} coins each.");





        }
    }


}