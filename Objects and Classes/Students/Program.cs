using System;
using System.Collections.Generic;
using System.Linq;


namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());
            var studentKeeper = new List<Student>();


            for (int i = 0; i < countOfStudents; i++)
            {
                string[] tokens = Console.ReadLine().Split(" ");

                string firstName = tokens[0];
                string lastName = tokens[1];
                double grade = double.Parse(tokens[2]);


                var currStudents = new Student(firstName, lastName, grade);
                studentKeeper.Add(currStudents);
            }
            foreach (var studennt in studentKeeper.OrderByDescending(x => x.Grade))
            {
                studennt.OverrideToString();
            }
        }
        class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public double Grade { get; set; }

            public Student(string firstName, string lastName, double grade)
            {
                FirstName = firstName;
                LastName = lastName;
                Grade = grade;
            }



            public void OverrideToString()
            {
                Console.WriteLine($"{this.FirstName} {this.LastName}: {this.Grade:f2}");
            }
        }
    }
}
