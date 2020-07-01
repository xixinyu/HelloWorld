using System;
using System.Collections.Generic;
using System.Text;

namespace GenericTest
{
    public class ShapeDisplay: IDisplay<Shape>
    {
        public void Show(Shape shape)
        {
            Console.WriteLine($"{shape.GetType()} Width: {shape.Width}, Height: {shape.Height}");
        }
    }
}
