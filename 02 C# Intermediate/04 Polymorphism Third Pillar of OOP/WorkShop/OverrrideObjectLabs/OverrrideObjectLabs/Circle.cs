using System;

namespace OverrrideObjectLabs
{
    public class Circle : Shape
    {
        public override void Draw()
        {
            //base.Draw();
            Console.WriteLine("I am Circle");
        }
    }
}
