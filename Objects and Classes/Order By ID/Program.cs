using System;
using System.Collections.Generic;
using System.Linq;

namespace Order_By_ID
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var studentKeeper = new List<People>();

            while (input != "End")
            {

                string[] tokens = input.Split(' ');

                string name = tokens[0];

                string id = tokens[1];

                int age = int.Parse(tokens[2]);

                var currStudents = new People(name, id, age);

                studentKeeper.Add(currStudents);

                input = Console.ReadLine();
            }
            foreach (var studennt in studentKeeper.OrderBy(x => x.Age))
            {
                Console.WriteLine($"{studennt.Name} with ID: {studennt.ID} is {studennt.Age} years old.");
            }
        }
        class People
        {
            public string Name { get; set; }
            public string ID { get; set; }
            public int Age { get; set; }

            public People(string name, string id, int age)
            {
                Name = name;
                ID = id;
                Age = age;
            }

        }
    }
}
