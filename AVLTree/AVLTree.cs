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
    }
}
