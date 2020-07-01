using System;

namespace GenericTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // in out 并不是指定T 是参数，还是返回值，而是指定此泛型是协变还是抗变
            // 协变  子类转父类 是协变
            IIndex<Rectangle> rectangle = RectangleCollection.GetRectangleCollection();
            var shapes = rectangle as IIndex<IShape>;

            for (int i = 0; i < shapes.Count; i++)
            {
                Console.WriteLine(shapes[i]);
            }

            // 抗变， 父类转子类是抗变
            IDisplay<Shape> shapeDisplay = new ShapeDisplay();
            IDisplay<Rectangle> rectangleDisplay = shapeDisplay;
            rectangleDisplay.Show(rectangle[0]);
        }
    }
}
