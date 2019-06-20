using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;



namespace StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            int n = int.Parse(Console.ReadLine());

            var dataKey = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                var student = Console.ReadLine();
                var grade = double.Parse(Console.ReadLine());

                if (!dataKey.ContainsKey(student))
                {
                    dataKey.Add(student, new List<double>());
                }
                dataKey[student].Add(grade);
            }
            dataKey = dataKey.Where(x => x.Value.Average() >= 4.50).ToDictionary(k => k.Key, v => v.Value);

            foreach (var student in dataKey.OrderByDescending(x => x.Value.Average()))
            {
                string name = student.Key;

                double averageGrade = student.Value.Average();

                Console.WriteLine("{0} -> {1:F2}", name, averageGrade);
            }

        }
    }
}
