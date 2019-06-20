using System;
using System.Globalization;
using System.Threading;
using System.Linq;
using System.Collections.Generic;
namespace Objects_and_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string[] phrases = new string[] { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
                            
            string[] eventss = new string[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };

            string[] author = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
                
            string[] city = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random phrase = new Random();
            Random events = new Random();
            Random authors = new Random();
            Random cities = new Random();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int phraseIndex = phrase.Next(0, phrases.Length);
                int eventIndex = phrase.Next(0, eventss.Length);
                int authorsIndex = phrase.Next(0, author.Length);
                int citiesIndex = phrase.Next(0, city.Length);
                Console.WriteLine($"{phrases[phraseIndex]} {eventss[eventIndex]} {author[authorsIndex]} - {city[citiesIndex]}");
            }


        }
    }
}
