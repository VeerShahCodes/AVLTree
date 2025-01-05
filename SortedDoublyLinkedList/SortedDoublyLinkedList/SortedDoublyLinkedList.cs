using System;

public class SortedDoublyLinkedList<T> where T : IComparable<T>
{
    private class Node
    {
        public T Data { get; set; }
        public Node Next { get; set; }
        public Node Prev { get; set; }

        public Node(T data)
        {
            Data = data;
            Next = null;
            Prev = null;
        }
    }

    private Node head;
    private Node tail;
    public int Count { get; private set; }

    public SortedDoublyLinkedList()
    {
        head = null;
        tail = null;
        Count = 0;
    }

    public void Add(T item)
    {
        Node newNode = new Node(item);

        if (head == null) 
        {
            head = tail = newNode;
        }
        else if (head.Data.CompareTo(item) >= 0) 
        {
            newNode.Next = head;
            head.Prev = newNode;
            head = newNode;
        }
        else
        {
            Node current = head;
            while (current.Next != null && current.Next.Data.CompareTo(item) < 0)
            {
                current = current.Next;
            }

            newNode.Next = current.Next;
            newNode.Prev = current;

            if (current.Next != null)
            {
                current.Next.Prev = newNode;
            }
            else 
            {
                tail = newNode;
            }

            current.Next = newNode;
        }

        Count++;
    }

    public bool Remove(T item)
    {
        Node current = head;

        while (current != null)
        {
            if (current.Data.CompareTo(item) == 0)
            {
                if (current.Prev != null)
                {
                    current.Prev.Next = current.Next;
                }
                else 
                {
                    head = current.Next;
                }

                if (current.Next != null)
                {
                    current.Next.Prev = current.Prev;
                }
                else 
                {
                    tail = current.Prev;
                }

                Count--;
                return true;
            }

            current = current.Next;
        }

        return false;
    }

    public void PrintList()
    {
        Node current = head;
        while (current != null)
        {
            Console.Write(current.Data + " ");
            current = current.Next;
        }
        Console.WriteLine();
    }

    public void PrintReverse()
    {
        Node current = tail;
        while (current != null)
        {
            Console.Write(current.Data + " ");
            current = current.Prev;
        }
        Console.WriteLine();
    }
}

