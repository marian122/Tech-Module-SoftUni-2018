    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace SoftUniCoffeOrders
    {
        class Program
        {
            static void Main(string[] args)
            {
                int count = int.Parse(Console.ReadLine());
                decimal orderPrice = 0;
                decimal totalprice = 0;
                List<string> priceList = new List<string>();
                for (int i = 0; i < count; i++)
                {
                    decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                    string[] orderDate = Console.ReadLine().Split('/');
                    decimal numberOfCapsules = decimal.Parse(Console.ReadLine());
                    int daysInMonth = DateTime.DaysInMonth(int.Parse(orderDate[2]), int.Parse(orderDate[1]));
                    orderPrice = daysInMonth * numberOfCapsules * pricePerCapsule;
                    totalprice += orderPrice;
                    priceList.Add($"The price for the coffee is: ${orderPrice:F2}");
                }
            
                foreach (var price in priceList)
                {
                    Console.WriteLine(price);
                }
                Console.WriteLine($"Total: ${totalprice:F2}");
            }
        }
    }
