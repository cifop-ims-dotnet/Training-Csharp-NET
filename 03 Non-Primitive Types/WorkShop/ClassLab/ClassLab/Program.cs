﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLab
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //var calc = new Calc();
            //calc.Add(1, 3);
            var calc = new Calc();
            
            var sum = Calc.Addv2(1, 2);
            Console.WriteLine(sum);
            //Console.WriteLine(calc.Total); 
        }
    }
}
