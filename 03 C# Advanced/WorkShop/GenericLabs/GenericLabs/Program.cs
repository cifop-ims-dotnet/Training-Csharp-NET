using System.Collections.Generic;

namespace GenericLabs
{
    class Program
    {
        static void Main()
        {
            //var container = new Container<int>(5);

            //Container<string> test2 = new Container<string>("cat");

            //Container<Employee> test3 = new Container<Employee>(new Employee());

            var utils = new Utilities();
            var result = utils.Max<int>(2, 1);

            var list = GetInitializedList<string>("cat", 5);
            foreach (var item in list)
            {
                System.Console.WriteLine(item);
            }
        }

        static ICollection<T> GetInitializedList<T>(T value, int count)
        {
            ICollection<T> list = new List<T>();
            AddItems(value, count, list);
            return list;
        }

        private static void AddItems<T>(T value, int count, ICollection<T> list)
        {
            for (int i = 0; i < count; i++)
            {
                list.Add(value);
            }
        }
    }
}
