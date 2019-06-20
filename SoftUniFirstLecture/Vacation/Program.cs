using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0.0;
            
           if (day == "Friday")
            {
                if (type == "Students")
                {
                    if (students >= 30)
                    {
                        price = 8.45 - (8.45 * 0.15);
                    }
                    else
                    {
                        price = 8.45;
                    }
                }
                else if (type == "Business")
                {
                    if (students >= 100)
                    {
                        students -= 10;
                        price = 10.9;
                    }
                    else
                    {
                        price = 10.9;
                    }
                }
                else if (type == "Regular")
                {
                    if (students >= 10 && students <= 20)
                    {
                        price = 15 - (15 * 0.05);
                    }                  
                    else
                    {
                        price = 15;
                    }
                }
            }
            else if (day == "Saturday")
            {
                if (type == "Students")
                {
                    if (students >= 30)
                    {
                        price = 9.8 - (9.8 * 0.15);
                    }
                    else
                    {
                        price = 9.8;
                    }
                }
                else if (type == "Business")
                {
                    if (students >= 100)
                    {
                        students -= 10;
                        price = 15.6;
                    }
                    else
                    {
                        price = 15.6;
                    }
                }
                else if (type == "Regular")
                {
                    if (students >= 10 && students <= 20)
                    {
                        price = 20 - (20 * 0.05);
                    }                 
                    else
	                {
                    price = 20;                    
                    }
                }
            }
            else if (day == "Sunday")
            {
                if (type == "Students")
                {
                    if (students >= 30)
                    {
                        price = 10.46 - (10.46 * 0.15);
                    }
                    else
                    {
                        price = 10.46;
                    }
                }
                else if (type == "Business")
                {
                    if (students >= 100)
                    {
                        students -= 10;
                        price = 16;
                    }
                    else
                    {
                        price = 16;
                    }
                }
                else if (type == "Regular")
                {
                    if (students >= 10 && students <= 20)
                    {
                        price = 22.5 - (22.5 * 0.05);
                    }                   
                    else
                    {
                        price = 22.5;
                    }
                }
            }
            var total = students * price;
            
            Console.WriteLine("Total price: {0:f2}", total);

        }
    }
}
