using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Bob", new DateTime(2000,1,1));

            Console.WriteLine(person.Age);

        }
    }
}
