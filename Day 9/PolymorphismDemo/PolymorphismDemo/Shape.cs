using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    public class Shape
    {
        public virtual void DrawShape()
        {
            Console.WriteLine("Drawing Shape");
        }
    }

    public class Circle: Shape
    {
        public override void DrawShape()
        {
            Console.WriteLine("Drawing Circle");
        }
    }

    public class Rectangle: Shape
    {
        public override void DrawShape()
        {
            Console.WriteLine("Drawing Rectangle");
        }
    }
}
