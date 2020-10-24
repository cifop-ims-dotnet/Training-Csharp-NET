using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLabs
{
    public abstract class Vehicule
    {
        public abstract void Display();
        //{
        //    Console.WriteLine("I am Vehicule");
        //}
    }
    public class Peugeot : Vehicule
    {
        public override void Display()
        {
            Console.WriteLine("I am Peugeot");
        }
    }

    public class BMW : Vehicule
    {
        public override void Display()
        {
            Console.WriteLine("I am BMW");
        }
    }

    public class Audi : Vehicule
    {
        public override void Display()
        {
            Console.WriteLine("I am Audi");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var audi = new Audi();
            var peugeot = new Peugeot();
            var bmw = new BMW();

            var parking = new List<Vehicule>();

            // var vh = new Vehicule();

            parking.Add(audi);
            parking.Add(peugeot);
            parking.Add(bmw);

            foreach (var vehicule in parking)
            {
                vehicule.Display();
            }

        }
    }
}
