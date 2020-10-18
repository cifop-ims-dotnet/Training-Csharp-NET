using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexersLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            var httpCookies = new HttpCookies();

            //httpCookies["username"] = "ahedfi001";
            //Console.WriteLine(httpCookies["username"]);

            //httpCookies.Fill();
            //httpCookies.GetCookie("key");
            //httpCookies.SetCookie("key", "value");

            var cards = new Cards();
            Console.WriteLine(cards[0]);
        }
    }
}
