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
        public Node<T> Add(T value, Node<T> current) //values are getting deleted after rotation
        {

            if (current == null) return new Node<T>(value);
            if(value.CompareTo(current.Value) < 0)
            {
                current.LeftChild = Add(value, current.LeftChild);
            }
            else if(value.CompareTo(current.Value) > 0)
            {
                current.RightChild = Add(value, current.RightChild);
            }
            current.UpdateHeight();
            return Balance(current);

        }

        public void Delete(T value)
        {

        }

        public Node<T> Balance(Node<T> current)
        {
            if (current.Balance < -1) // Right-Heavy case
            {
                // Left-Right Case: Left child is right-heavy
                if (current.LeftChild.Balance > 0)
                {
                    // Perform left rotation on the left child (this is the "inner rotation")
                    current.LeftChild = RotateLeft(current.LeftChild);
                }

                // Perform right rotation on the current node (this is the "outer rotation")
                return RotateRight(current);
            }
            else if (current.Balance > 1) // Left-Heavy case
            {
                // Right-Left Case: Right child is left-heavy
                if (current.RightChild.Balance < 0)
                {
                    // Perform right rotation on the right child (this is the "inner rotation")
                    current.RightChild = RotateRight(current.RightChild);
                }

                // Perform left rotation on the current node (this is the "outer rotation")
                return RotateLeft(current);
            }

            // Tree is balanced
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

        public void DepthFirstTraversal(Node<T> current)
        {
            if (current == null) return;
            Console.WriteLine("Value: " + current.Value + ", Height: " + current.Height);
            if(current.LeftChild != null)
            {
                DepthFirstTraversal(current.LeftChild);
            }
            if(current.RightChild != null)
            {
                DepthFirstTraversal(current.RightChild);
            }
        }
    }

}
