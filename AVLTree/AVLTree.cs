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
            Root = Delete(value, Root);
        }

        private Node<T> Delete(T value, Node<T> current)
        {
            if (current == null) return null;

            if (value.CompareTo(current.Value) < 0)
            {
                current.LeftChild = Delete(value, current.LeftChild);

            }
            else if(value.CompareTo(current.Value) > 0)
            {
                current.RightChild = Delete(value, current.RightChild);
            }
            else
            {
                if (value.Equals(current.Value))
                {
                    if (current.ChildCount == 0)
                    {
                        return null;
                    }
                    else if (current.ChildCount == 1)
                    {
                        if (current.LeftChild != null)
                        {
                            return current.LeftChild;
                        }
                        else
                        {
                            return current.RightChild;
                        }

                    }
                    else
                    {
                        Node<T> temp = FindMin(current.RightChild);
                        current.Value = temp.Value; 
                        current.RightChild = Delete(temp.Value, current.RightChild);

                    }
                }
            }
            

 

            current.UpdateHeight();
            return Balance(current);
            

        }
        private Node<T> FindMin(Node<T> node)
        {
            while (node.LeftChild != null)
            {
                node = node.LeftChild;
            }
            return node;
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



        public void PreOrderTraversal(Node<T> current)
        {
            if (current == null) return;
            current.WriteData();
            if(current.LeftChild != null)
            {
                PreOrderTraversal(current.LeftChild);
            }
            if(current.RightChild != null)
            {
                PreOrderTraversal(current.RightChild);
            }
        }

        public void PostOrderTraversal(Node<T> current)
        {
            if (current == null) return;
            PostOrderTraversal(current.LeftChild);
            PostOrderTraversal(current.RightChild);
            current.WriteData();
        }






    }

}
