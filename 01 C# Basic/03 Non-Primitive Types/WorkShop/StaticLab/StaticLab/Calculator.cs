using System.Runtime.Remoting.Messaging;

namespace StaticLab
{
    public static class Calculator
    {
        public static string Message;

        public static int Result;
        public static int Add(int a, int b)
        {
            Result = 0;
            Reset();
            return a + b;
        }
        public static void Reset()
        {

        }
    }
}
