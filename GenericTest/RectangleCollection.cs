using System;
using System.Collections.Generic;
using System.Text;

namespace GenericTest
{
    public class RectangleCollection : IIndex<Rectangle>
    {
        private Rectangle[] data = new Rectangle[3]
        {
            new Rectangle{Height = 2,Width = 5},
            new Rectangle{Height = 3,Width = 7},
            new Rectangle{Height = 4.5,Width = 2.9}
        };

        private static RectangleCollection coll;

        public static RectangleCollection GetRectangleCollection()
        {
            return coll ?? new RectangleCollection();
        }

        public Rectangle this[int index]
        {
            get
            {
                if (index<0 || index > data.Length)
                {
                    throw new ArgumentOutOfRangeException();
                }

                return data[index];
            }
        }

        public int Count => data.Length;
    }
}
