using System;
using System.Collections.Generic;
using System.Threading;
using System.Globalization;
using System.Linq;

namespace StudentsTwo
{
    class Program
    {
        static void Main(string[] args)
        {


            List<Students> studenties = new List<Students>();
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] data = command.Split();

                string firstName = data[0];
                string lastName = data[1];
                int age = int.Parse(data[2]);
                string hometown = data[3];

                Students studentt = studenties.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);
                if (studentt == null)
                {
                    studenties.Add(new Students()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        Hometown = hometown
                    });
                }
                else
                {

                    studentt.FirstName = firstName;
                    studentt.LastName = lastName;
                    studentt.Age = age;
                    studentt.Hometown = hometown;
                    
                }                
                command = Console.ReadLine();

            }
            string filterHometown = Console.ReadLine();
            foreach (Students studentt in studenties)
            {
                if (studentt.Hometown == filterHometown)
                {
                    Console.WriteLine($"{studentt.FirstName} {studentt.LastName} is {studentt.Age} years old.");
                }
            }

        }
        
        class Students
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string Hometown { get; set; }
        }
    }
}

