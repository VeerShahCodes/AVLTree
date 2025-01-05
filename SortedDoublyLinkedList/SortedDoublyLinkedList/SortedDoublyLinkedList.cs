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
            while (current.Next != null && current.Next.Value.CompareTo(current.Value) < 0)
            {
                current = current.Next;
            }
            Node<T> newNode = new Node<T>(val);

            if (current.Next == null)
            {
                ConnectNodes(current, newNode, null);
            }
            else
            {
                ConnectNodes(current, newNode, current.Next);

            }




        }
        public void ConnectNodes(Node<T> previous, Node<T> newNode, Node<T> next)
        {

            previous.Next = newNode;

            
            newNode.Previous = previous;
            newNode.Next = next;
            if(next != null)
            {
                next.Previous = newNode;

            }
        }

        public void WriteNodes()
        {
            Node<T> current = Head;
            while(current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
        }
    }
}
