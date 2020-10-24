using System;
using System.Collections;
using System.Collections.Generic;

namespace BoxingUnboxingLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 10;

            ArrayList arrayList = new ArrayList();
            arrayList.Add(number);
            arrayList.Add("john");
            arrayList.Add(2.3);

            int newNumber = (int)arrayList[0];

            var list = new List<int>();
            list.Add(number);

            newNumber = list[0];
        }
    }
}
