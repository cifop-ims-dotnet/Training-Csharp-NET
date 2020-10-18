using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Ahmed Hedfi";
            Console.WriteLine("Trim : '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper : '{0}'", fullName.Trim().ToUpper());
            int index = fullName.IndexOf(' ');
            string firstName = fullName.Substring(0, index);
            string lastName = fullName.Substring(index + 1);
            Console.WriteLine("firstName : '{0}'", firstName);
            Console.WriteLine("lastName : '{0}'", lastName);
            var replacedString = fullName.Replace("Ahmed", "hello");
            Console.WriteLine(fullName.Replace("Ahmed", "hello"));

            var spiltedString = fullName.Split(' ');
            var fn = spiltedString[0];
            var ln = spiltedString[1];
            Console.WriteLine("firstName : '{0}'", fn);
            Console.WriteLine("lastName : '{0}'", ln);
            if (String.IsNullOrEmpty(null))
                Console.WriteLine("Invalid");
            string str = "100,150";
            decimal ammount = Convert.ToDecimal(str);
            var formattedAmmount = ammount.ToString("C1",new CultureInfo("de-DE"));
            Console.WriteLine(formattedAmmount);

        }
    }
}
