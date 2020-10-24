using System;
using Unity.Interfaces;

namespace Unity.Implementations
{

    public class HelloService : IHelloService
    {
        public void SayHello()
        {
            Console.WriteLine("Hello !");
        }
    }
}
