using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avlTree
{
    public class AVLTree<T>
        where T : IComparable<T>
    {
        public Node<T> Root;
        public int balance;

        public AVLTree()
        {

        }

        public int UpdateHeight(Node<T> current, Node<T> child1, Node<T> child2)
        {
            if (child2 == null)
            {
                return child1.Height + 1;
            }
            else
            {
                return child2.Height + 1;
            }
        }
        public void Add(T value, Node<T> current)
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
                }
                else
                {
                    current.LeftChild = new Node<T>(value);
                    current.Height = UpdateHeight(current, current.LeftChild, current.RightChild);
                    Console.WriteLine(current.Height);
                    return;
                }
            }
            else
            {
                if(current.RightChild != null)
                {
                    Add(value, current.RightChild);
                }
                else
                {
                    current.RightChild = new Node<T>(value);
                    current.Height = UpdateHeight(current, current.RightChild, current.LeftChild);
                    Console.WriteLine(current.Height);
                    return;
                }
            }


        }

        public void Delete(T value)
        {

        }
    }
}
