using System;
using System.Collections.Generic;
using System.Text;

namespace GenericTest
{
    public interface IIndex<out T>
    {
        T this[int index] { get; }
        int Count { get; }
    }
}
