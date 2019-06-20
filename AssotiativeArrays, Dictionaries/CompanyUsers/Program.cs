using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var result = new Dictionary<string, List<string>>();

            while (input != "End")
            {
                string[] tokens = input
                    .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string currentCompany = tokens[0];
                string employId = tokens[1];

                if (!result.ContainsKey(currentCompany))
                {
                    result.Add(currentCompany, new List<string>());
                }
                if (!result[currentCompany].Contains(employId))
                {
                    result[currentCompany].Add(employId);
                }
                input = Console.ReadLine();

            }
            foreach (var company in result.OrderBy(x => x.Key))
            {
                string nameCompany = company.Key;
                var employees = company.Value;

                Console.WriteLine(nameCompany);
                foreach (var employ in employees)
                {
                    Console.WriteLine("-- {0}", employ);
                }
            }


        }
    }
}
