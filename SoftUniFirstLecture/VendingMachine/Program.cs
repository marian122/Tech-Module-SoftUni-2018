using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "text";

            decimal s = 0;

            while (text != "start")
            {
                text = Console.ReadLine().ToLower();
                if (text == "1" || text == "2")
                {
                    decimal coins = decimal.Parse(text);
                    s += coins;
                }
                else if (text == "0.1")
                {
                    s += 0.1m;
                }
                else if (text == "0.2")
                {
                    s += 0.2m;
                }
                else if (text == "0.5")
                {
                    s += 0.5m;
                }
                else if (text == "1")
                {
                    s += 1m;
                }
                else if (text == "2")
                {
                    s += 2m;
                }
                else if (text == "start")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Cannot accept {0}", text);
                }               
            }
            decimal price;
            while (text != "End")
            {
                text = Console.ReadLine();
                if (text == "Nuts")
                {
                    price = 2m;
                    if (price <= s)
                    {
                        Console.WriteLine("Purchased nuts");
                        s -= price;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }                 
                }
                else if (text == "Water")
                {
                    price = 0.7m;
                    if (price <= s)
                    {
                        Console.WriteLine("Purchased water");
                        s -= price;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (text == "Crisps")
                {
                    price = 1.5m;
                    if (price <= s)
                    {
                        Console.WriteLine("Purchased crisps");
                        s -= price;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (text == "Soda")
                {
                    price = 0.8m;
                    if (price <= s)
                    {
                        Console.WriteLine("Purchased soda");
                        s -= price;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (text == "Coke")
                {
                    price = 1m;
                    if (price <= s)
                    {
                        Console.WriteLine("Purchased coke");
                        s -= price;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");                       
                    }
                }
                else if (text == "End")
                {
                    Console.WriteLine("Change: {0:f2}", s);
                    break;
                }
                else if (text != "Coke" || text != "Nuts" || text != "Water" || text != "Soda" || text != "Crisps" || text != "End")
                {
                    Console.WriteLine("Invalid product");
                }
            }

        }
    }
}
