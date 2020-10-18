using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugLabs
{
    class Program
    {
        public static void Main(string[] args)
        {
#if DEBUG

#endif

#warning this code should be refactored
            //TODO : It is Hack
            #region Sart
            #endregion

            TextWriterTraceListener tr1 = new TextWriterTraceListener(System.Console.Out);
            Debug.Listeners.Add(tr1);

            TextWriterTraceListener tr2 = new TextWriterTraceListener(System.IO.File.CreateText("Output.txt"));
            Trace.Listeners.Add(tr2);

            Debug.WriteLine("Debug: Main method");
            Debug.Flush();
            Trace.WriteLine("Trace: Main method");
            Trace.Flush();
            var numbers = new List<int> { 1, 2,3,4 };
            var smallests = GetSmallests(numbers, 3);


            foreach (var number in smallests)
                Console.WriteLine(number);
        }

        public static List<int> GetSmallests(List<int> list, int count)
        {
            // Fail Fast
            //if (list == null)
            //    throw new ArgumentNullException("list", "list should not be null");

            //if (count < 1 || count > list.Count)
            //    throw new ArgumentException("count", "count should not be between 1 and length of the list");

            var smallests = new List<int>();
            var tempList = new List<int>(list);
            //tempList.AddRange(list);

            while (smallests.Count < count)
            {
                var min = GetSmallest(tempList);
                smallests.Add(min);
                tempList.Remove(min);
            }

            return smallests;
        }

        private static int GetSmallest(List<int> list)
        {
            //if (list.Count == 0)
            //    throw new ArgumentException(nameof(list), "list shoud not be empty");

            // Assume the first number is the smallest
            var min = list[0];
            for (var i = 1; i < list.Count; i++)
            {
                if (list[i] < min)
                    min = list[i];
            }
            return min;
        }
    }
}
