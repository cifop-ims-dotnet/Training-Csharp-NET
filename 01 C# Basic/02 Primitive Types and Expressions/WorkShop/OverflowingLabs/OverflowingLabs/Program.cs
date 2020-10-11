using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverflowingLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            float number = 1.2f;
            double number2 = 1.2;
            decimal money = 1.2m;

            try
            {
                checked
                {
                    byte value = 255;
                    value++;
                    Console.WriteLine(value);
                }
            }
            catch (Exception e)
            {

                // handler execption
                Console.WriteLine("overflow occurs !!");
            }
        }
    }
}
