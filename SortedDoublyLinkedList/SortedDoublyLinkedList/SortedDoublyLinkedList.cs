using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedDoublyLinkedList
{
    public class SortedDoublyLinkedList<T>
        where T : IComparable<T>
    {
        Node<T> Head { get; set; }

        public SortedDoublyLinkedList(T startVal)
        {
            Head = new Node<T>(startVal);
        }
        public void Insert(T val)
        {
            Node<T> current = Head;
            

        }
        public void ConnectNodes(Node<T> previous, Node<T> newNode, Node<T> next)
        {
            previous.Next = newNode;
            newNode.Previous = previous;
            newNode.Next = next;
            next.Previous = newNode;
        }
    }
}
