using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableLabs
{
    public class Foo
    {
        public string Bar { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //var r = (c) ? 1 : 0;
            //int number = null;
            //Nullable<int> numberNullable = null;
            int? number2 = null;
            int number3 = number2 ?? -1;
            bool? isTrue = null;

            var foo = new Foo();
            foo = null;
            string result = foo?.Bar;
            Console.WriteLine(result);

            //Console.WriteLine(number2.Value);
            char? c = null;
            DateTime? date = null;
            if (date.HasValue)
                Console.WriteLine(date.Value);
            if (number2.HasValue)
                Console.WriteLine("number has value");

            dynamic value = 0;
            value = "123";
            dynamic foo2 = new Foo();
            value = foo2.Start().Go().Stop();
            Console.WriteLine(value);
        }
    }
}
