using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodLabs
{
    class Person
    {

    }
    partial class Program
    {
        static void Main(string[] args)
        {
            //var calc = new Calculator();
            //var result = calc.Add("start calculating", new int[3] { 10, 20, 30 });
            //result = calc.Add("start calculating", 1, 2, 3, 4, 5, 6, 7, 8, 10);
            //Console.WriteLine(result);


            //int number = 1;
            //Increment(ref number);
            //Console.WriteLine(number);

            int outNumber = 3;
            Set(out outNumber);
            Console.WriteLine(outNumber);

            string value = "123k";
            int formatedNumber;
            
            var result = int.TryParse(value, out formatedNumber);
        }

        static void Increment(ref int a)
        {
            a += 2;
        }

        static void Set(out int number)
        {
            number = 10;
        }
    }
}
