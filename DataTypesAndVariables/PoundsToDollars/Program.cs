﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            double britishPounds = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:f3}", britishPounds * 1.31);
        }
    }
}
