using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace avlTree
{
    public class AVLTree<T>
        where T : IComparable<T>
    {
        public Node<T> Root;


        public AVLTree()
        {

        }

        public void Add(T value)
        {
            Root = Add(value, Root);
        }
        public Node<T> Add(T value, Node<T> current) 
        {

            if (current == null) return new Node<T>(value);
            if(value.CompareTo(current.Value) < 0)
            {
                current.LeftChild = Add(value, current.LeftChild);
            }
            else
            {
                current.RightChild = Add(value, current.RightChild);
            }
            current.UpdateHeight();
            return Balance(current);

        }

        public void Delete(T value)
        {
            if (Root == null) return;
            Delete(value, Root);
        }

        private void Delete(T value, Node<T> current)
        {
            if (current == null) return;
            if(value.Equals(current.Value))
            {
                if (current.ChildCount == 0) current = null;
                else if(current.ChildCount == 1)
                {
                     if(current.LeftChild != null)
                     {
                        current = current.LeftChild;
                     }
                     else
                     {
                        current = current.RightChild;
                     }

                }
                else
                {

                }
            }
            else
            {
                if(value.CompareTo(current.Value) < 0)
                {
                    Delete(value, current.LeftChild);
                }
                else
                {
                    Delete(value, current.RightChild);
                }
            }

        }

        public Node<T> Balance(Node<T> current)
        {
            if (current.Balance < -1)
            {
                if (current.LeftChild.Balance > 0)
                {
                    current.LeftChild = RotateLeft(current.LeftChild);
                }

                return RotateRight(current);
            }
            else if (current.Balance > 1)
            {
                if (current.RightChild.Balance < 0)
                {
                    current.RightChild = RotateRight(current.RightChild);
                }

                return RotateLeft(current);
            }

            return current;
        }
        public Node<T> RotateLeft(Node<T> current)
        {
            if (current.RightChild == null)
            {
                return current;
            }

            Node<T> newRoot = current.RightChild;

            current.RightChild = newRoot.LeftChild;  
            newRoot.LeftChild = current;  

            current.UpdateHeight();
            newRoot.UpdateHeight();

            return newRoot;
        }

        public Node<T> RotateRight(Node<T> current)
        {
            if (current.LeftChild == null)
            {
                return current;
            }

            Node<T> newRoot = current.LeftChild;

            current.LeftChild = newRoot.RightChild;  
            newRoot.RightChild = current;  

            current.UpdateHeight();
            newRoot.UpdateHeight();

            return newRoot;
        }



        public void BreadthFirstTraversal(Node<T> current)
        {
            if (current == null)
            {
                return;
            }

            Queue<Node<T>> queue = new Queue<Node<T>>();
            queue.Enqueue(current);  

            while (queue.Count > 0)
            {
                Node<T> node = queue.Dequeue();

                Console.WriteLine("Value: " + node.Value + ", Height: " + node.Height);

                if (node.LeftChild != null)
                {
                    queue.Enqueue(node.LeftChild);
                }

                if (node.RightChild != null)
                {
                    queue.Enqueue(node.RightChild);
                }
            }
        }

    }

}
