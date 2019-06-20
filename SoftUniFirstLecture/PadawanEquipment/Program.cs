using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal ivanChoBudget = decimal.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            decimal lightsabersPrice = decimal.Parse(Console.ReadLine());
            decimal robesPrice = decimal.Parse(Console.ReadLine());
            decimal beltsPrice = decimal.Parse(Console.ReadLine());
            decimal beltForStudents = studentsCount - (studentsCount / 6);
            decimal studentNumber = Math.Ceiling(studentsCount * 0.1m) + studentsCount;

            var neededEquipment = lightsabersPrice * studentNumber + robesPrice * studentsCount + beltsPrice * beltForStudents;
            
            if (ivanChoBudget >= neededEquipment)
            {
                Console.WriteLine("The money is enough - it would cost {0:f2}lv.", neededEquipment);
            }
            else
            {
                Console.WriteLine("Ivan Cho will need {0:f2}lv more.", neededEquipment - ivanChoBudget);
            }

        }
    }
}
