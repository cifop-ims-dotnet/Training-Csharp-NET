using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace StaticLab
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //decimal number = 100000000000000000000m + 0.00001m;

            //var calculator = new Calculator();
            //var result = calculator.Add(1, 2);
            //var result = Calculator.Add(1, 2);
            //System.Console.WriteLine(result);

            //String
            //var numbers = new int[3] { 1, 2, 3 };
            //var list = string.Join(",", numbers);
            //System.Console.WriteLine(list);

            //// Immutable
            //var message = "Hello";  // Hello
            //message += " World";    // Hello World


            //// Immutable
            //const double Pi = 3.14;
            //Pi = 3;


            //Verbatim String
            //var path = @"C:\mypath\myfolder\";
            //var firstName = "John";
            //var lastName = "Smith";
            ////var name = firstName + " " + lastName;
            ////var name = string.Format("FullName = {0} {1}", firstName, lastName);
            //var name = $"FullName {firstName} {lastName}";

            //Enums
            var monday = Days.Monday;
            //System.Console.WriteLine((byte) monday);
            //var day1 = 1;
            //if(day1 == (int)Days.Monday)
            //{
            //    System.Console.WriteLine("It is monday");
            //}
            var weekend = Days.Saturday | Days.Sunday; //1100000

            if((weekend & Days.Sunday) == Days.Sunday)
                System.Console.WriteLine("It is monday");

            System.Console.WriteLine((byte)weekend);

            //Part: Static Method
            var person = new Person();
            person.Id = 1;
            person.Name = "Jhon";

            var person2 = new Person();
            person2.Id = 1;
            person2.Name = "Bob";
            if(person == person2)
            {

            }

            string name =(string)person;// var temp = person.name; var name = temp;

        }
    }
}
