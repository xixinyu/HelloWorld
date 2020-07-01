using System;
using System.Collections.Generic;
using System.Text;

namespace GenericTest
{
    public class Shape: IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override string ToString()
        {
            return $"Width: {Width}, Height: {Height}";
        }
    }
}
