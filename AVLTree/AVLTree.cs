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


            //if(value.CompareTo(current.Value) < 0)
            //{
            //    if(current.LeftChild != null)
            //    {
            //        Add(value, current.LeftChild);
            //        current.UpdateHeight();
            //        Node<T> returnNode;
            //        if (current.Balance > 1)
            //        {
            //            returnNode = RotateLeft(current);
            //            returnNode.UpdateHeight();
            //        }
            //        else if (current.Balance < -1)
            //        {
            //            returnNode = RotateRight(current);
            //            returnNode.UpdateHeight();
            //        }
            //        current.UpdateHeight();
            //    }
            //    else
            //    {
            //        current.LeftChild = new Node<T>(value);
            //        return;
            //    }
            //}
            //else
            //{
            //    if(current.RightChild != null)
            //    {
            //        Add(value, current.RightChild);
            //        current.UpdateHeight();
            //        Node<T> returnNode;
            //        if (current.Balance > 1) //height is being calculated incorrectly which is causing this if statement to not be hit when current is 7.
            //        {
            //            returnNode = RotateLeft(current);
            //            if(current == Root) Root = returnNode;
            //            returnNode.UpdateHeight();
            //        }
            //        else if (current.Balance < -1)
            //        {
            //            returnNode = RotateRight(current);
            //            if (current == Root) Root = returnNode;
            //            returnNode.UpdateHeight();
            //        }
            //        current.UpdateHeight();
            //    }
            //    else
            //    {
            //        current.RightChild = new Node<T>(value);
            //        return;
            //    }
            //}


        }

        public void Delete(T value)
        {

        }

        public Node<T> Balance(Node<T> current)
        {
            if(current.Balance < -1)
            {
                //if(current.LeftChild != null)
                //{
                //    if (current.LeftChild.Balance < 0)
                //    {
                //        current.LeftChild = RotateLeft(current.LeftChild);
                //    }
                //}

                return RotateRight(current);
            }
            else if(current.Balance > 1)
            {

                //if(current.RightChild != null)
                //{
                //    if (current.RightChild.Balance > 0)
                //    {
                //        current.RightChild = RotateRight(current.RightChild);
                //    }
                //}

                return RotateLeft(current);
            }
            return current;
        }
        public Node<T> RotateLeft(Node<T> current) 
        {
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
