using Unity.Interfaces;

namespace Unity.Implementations
{
    public class Shell : IShell
    {
        private readonly IGreetingService _serviceManager;

        public Shell(IGreetingService serviceManager)
        {
            _serviceManager = serviceManager;
        }
        public void Start()
        {
            _serviceManager.DisplayGreetingMsg();
        }
    }
}
