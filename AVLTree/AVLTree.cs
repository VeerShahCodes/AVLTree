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
        public void Add(T value, Node<T> current) //values are getting deleted after rotation
        {
            
            if (Root == null)
            {
                Root = new Node<T>(value);
                return;
            }

            if(value.CompareTo(current.Value) < 0)
            {
                if(current.LeftChild != null)
                {
                    Add(value, current.LeftChild);
                    current.UpdateHeight();
                    Node<T> returnNode;
                    if (current.Balance > 1)
                    {
                        returnNode = RotateLeft(current);
                    }
                    else if (current.Balance < -1)
                    {
                        returnNode = RotateRight(current);
                    }
                    current.UpdateHeight();
                }
                else
                {
                    current.LeftChild = new Node<T>(value);
                    return;
                }
            }
            else
            {
                if(current.RightChild != null)
                {
                    Add(value, current.RightChild);
                    current.UpdateHeight();
                    Node<T> returnNode;
                    if (current.Balance > 1) //height is being calculated incorrectly which is causing this if statement to not be hit when current is 7.
                    {
                        returnNode = RotateLeft(current);
                        if(returnNode.LeftChild == Root)
                        {
                            Root = returnNode;
                        }
                    }
                    else if (current.Balance < -1)
                    {
                        returnNode = RotateRight(current);
                        if (returnNode.LeftChild == Root)
                        {
                            Root = returnNode;
                        }
                    }
                    //current.UpdateHeight();
                }
                else
                {
                    current.RightChild = new Node<T>(value);
                    return;
                }
            }


        }

        public void Delete(T value)
        {

        }

  
        public Node<T> RotateLeft(Node<T> current) 
        {
            Node<T> rightChild = current.RightChild;
            Node<T> ogLeftChild = rightChild.LeftChild;
            Node<T> ogCurrent = current;
            current = rightChild;
            rightChild.LeftChild = ogCurrent;
            ogCurrent.RightChild = null;
            ogCurrent.LeftChild = ogLeftChild;
            return rightChild;
        }

        public Node<T> RotateRight(Node<T> current) 
        {
            Node<T> leftChild = current.LeftChild;
            Node<T> ogRightChild = leftChild.RightChild;
            leftChild.RightChild = current;
            current.LeftChild = null;
            current.RightChild = ogRightChild;
            return leftChild;
        }

        public void BreadthFirstTraversal(Node<T> current)
        {
            Console.WriteLine("Value: " + current.Value + ", Height: " + current.Height);
            if(current.LeftChild != null)
            {
                BreadthFirstTraversal(current.LeftChild);
            }
            if(current.RightChild != null)
            {
                BreadthFirstTraversal(current.RightChild);
            }
        }
    }

}
