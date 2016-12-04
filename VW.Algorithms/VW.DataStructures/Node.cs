using System;

namespace VW.DataStructures
{
    public class Node<T>: IComparable<T>
    {
        public T Value { get; set; }
        public int CompareTo(T other)
        {
            throw new NotImplementedException();
        }

    }
}