﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrrideObjectLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            var cirlce = new Circle();
            //var cirlce2 = new Circle();
            var cirlce2 = cirlce;
            cirlce.Draw();

            Shape shape = cirlce;
            shape.Draw(); 

            var baseShape = new Shape();
            baseShape.Draw();



            var person = new Person { FirstName = "bill", LastName = "macfield" };
            Console.WriteLine(1);
            Console.WriteLine(new Person());

            if(cirlce == cirlce2)
            {
            }

            if (cirlce.Equals(cirlce2))
            {
            }

            var content = "hello";
            var content2 = "hello";

            if(content == content2)
            {
            }

            if (content.Equals(content2))
            {
            }



            var point1 = new Point { X = 1, Y = 1 };
            var point2 = new Point { X = 1, Y = 1 };

            if (point1 == point2)
            {

            }
            //var point2 = point1;
            if(point1.Equals(point2))
            {
                Console.WriteLine("point1 == point2");
            }
        }
    }
}
