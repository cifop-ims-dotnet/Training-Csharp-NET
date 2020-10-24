using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterfaceLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            var moveableObj = new MoveableOject();
            ILeft left = moveableObj;
            left.Move();

            ((IRight)moveableObj).Move();
        }
    }
}
