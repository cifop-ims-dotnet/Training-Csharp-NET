using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysLab
{
    class Program
    {
        static void Main(string[] args)
        {
            const int numberOfArrrays = 3;
            const int numberOfColumns = 2;
            var matrix = new int[numberOfArrrays, numberOfColumns]
            {
                {1, 2},
                {3, 4},
                {5, 6}
            };

            for (int arrayIndex = 0; arrayIndex < numberOfArrrays; arrayIndex++)
            {
                for (int elementIndex = 0; elementIndex < numberOfColumns; elementIndex++)
                {
                    Console.WriteLine(matrix[arrayIndex, elementIndex]);
                }
            }

            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 0 };
            //Length
            Console.WriteLine("Length: " + numbers.Length);

            //IndexOf()
            var index = Array.IndexOf(numbers, 2);
            Console.WriteLine("Index of 2: " + index);

            //Clear()
            Array.Clear(numbers, 3, 3);

            Console.WriteLine("Effect of Clear()");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            //Copy()
            int[] another = new int[numbers.Length];

            Array.Copy(numbers, another, numbers.Length);

            Console.WriteLine("Effect of Copy()");
            foreach (var number in another)
            {
                Console.WriteLine(number);
            }

            //Sort()
            Array.Sort(numbers);
            Console.WriteLine("Effect of Sort()");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            //Reverse()
            Array.Reverse(numbers);
            Console.WriteLine("Effect of Reverse()");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
