using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Interfaces;

namespace Unity.Implementations
{
    public class GreetingService : IGreetingService
    {
        private readonly IHelloService _service;

        public GreetingService(IHelloService service)
        {
            _service = service;
        }
        public void DisplayGreetingMsg()
        {
            _service.SayHello();
        }
    }
}
