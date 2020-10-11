using CompanyName.ApplicationName.Services;

namespace ComapnyName.ApplicationName.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();
            var result = calc.Add(1, 2);
            System.Console.WriteLine(result);
            System.Console.ReadLine();
        }
    }
}
