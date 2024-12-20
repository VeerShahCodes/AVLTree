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
        public Node<T> LeftChild {  get; set; }
        public Node<T> RightChild { get; set; }
        public T Value {  get; set; }
        public int Height { get; set; }
        public int ChildCount { get; set; }
        public int Balance { get; set; }
        public Node(T val)
        {
            Value = val;
            Height = 1;
        }
    }
}
