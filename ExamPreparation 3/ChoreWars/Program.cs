using System;
using System.Text.RegularExpressions;

namespace ChoreWars
{
    class Program
    {
        static void Main(string[] args)
        {

            var dishesMin = 0;
            var cleaningMing = 0;
            var loundryMin = 0;

            var dishesPattern = @"(?<=<)[a-z0-9]+(?=>)";
            var cleaningPattern = @"(?<=\[)[A-Z0-9]+(?=\])";
            var loundryPattern = @"(?<={).+(?=})";

            string input = Console.ReadLine();

            while (input != "wife is happy")
            {

                var disheshMatch = Regex.Match(input, dishesPattern);
                var cleaningMatch = Regex.Match(input, cleaningPattern);
                var loundryMatch = Regex.Match(input, loundryPattern);

                if (disheshMatch.Success)
                {
                    string dishesStr = disheshMatch.ToString();
                    string numPattern = @"\d";

                    MatchCollection nums = Regex.Matches(dishesStr, numPattern);

                    foreach (var match in nums)
                    {
                        int num = int.Parse(match.ToString());
                        dishesMin += num;
                    }
                }
                else if (cleaningMatch.Success)
                {
                    string cleaningString = cleaningMatch.ToString();
                    string numPattern = @"\d";

                    MatchCollection nums = Regex.Matches(cleaningString, numPattern);

                    foreach (var match in nums)
                    {
                        int num = int.Parse(match.ToString());
                        cleaningMing += num;
                    }
                }
                else if (loundryMatch.Success)
                {
                    string loundryString = loundryMatch.ToString();
                    string numPattern = @"\d";

                    MatchCollection nums = Regex.Matches(loundryString, numPattern);

                    foreach (var match in nums)
                    {
                        int num = int.Parse(match.ToString());
                        loundryMin += num;
                    }
                }
                input = Console.ReadLine();
            }

            var totalmin = loundryMin + dishesMin + cleaningMing;

            Console.WriteLine($"Doing the dishes - {dishesMin} min.");
            Console.WriteLine($"Cleaning the house - {cleaningMing} min.");
            Console.WriteLine($"Doing the laundry - {loundryMin} min.");
            Console.WriteLine($"Total - {totalmin} min.");


        }
    }
}
