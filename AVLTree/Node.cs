using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avlTree
{
    public class Node<T>
        where T : IComparable<T>
    {
        public Node<T> leftChild;
        public Node<T> rightChild;
        public T value;
        public int height;
        public Node(T val)
        {
            value = val;
        }
    }
}
