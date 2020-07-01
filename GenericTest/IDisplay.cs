using System;
using System.Collections.Generic;
using System.Text;

namespace GenericTest
{
    public interface IDisplay<in T>
    {
        void Show(T item);
    }
}
