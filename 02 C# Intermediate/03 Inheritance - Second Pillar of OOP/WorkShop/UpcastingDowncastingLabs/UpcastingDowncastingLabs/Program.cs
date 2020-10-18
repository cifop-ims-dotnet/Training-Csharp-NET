using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingDowncastingLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle();
            circle.Name = "Circle";
            circle.Diameter = 10;

            var subCircle = new SubCircle();
            subCircle.Name = "SubCircle";
            subCircle.Diameter = 20;
            subCircle.Position = 0;

            var anotherShape = new Shape();
            if (anotherShape is SubCircle)
            {

            }

            Shape shape = subCircle;
            Console.WriteLine(shape.Name);

            Square anotherCircle = shape as Square;
            if(shape is Square)
            {
                Square square = (Square)shape;
            }
            if(anotherCircle != null)
            {


            }

        }
    }
}
